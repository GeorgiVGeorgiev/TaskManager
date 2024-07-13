namespace TaskManager.Services.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;
    using TaskManager.Web.ViewModels.Worker;

    public class AdminService : IAdminService
    {
        private readonly TaskManagerDbContext dbContext;
        private readonly IUserService userService;

        public AdminService(TaskManagerDbContext dbContext, IUserService userService)
        {
            this.dbContext = dbContext;
            this.userService = userService;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            IEnumerable<UserViewModel> users = await this.dbContext
                .Users
                .Select(u => new UserViewModel
                {
                    Id = u.Id.ToString(),
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                })
                .ToArrayAsync();

            return users;
        }

        public async Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync()
        {
            IEnumerable<AllWorkersViewModel> workers = await this.dbContext
                .Workers
                .Include(w => w.User)
                .Select(u => new AllWorkersViewModel
                {
                    Id = u.Id.ToString(),
                    FirstName = u.User.FirstName,
                    LastName = u.User.LastName,
                    Email = u.User.Email,
                    PhoneNumer = u.PhoneNumber,
                    Position = u.Position,
                    UserId = u.UserId.ToString()
                })
                .ToArrayAsync();

            return workers;
        }

        public async Task<UserViewModel> GetUserByIdAsync(string UserId)
        {
            ApplicationUser user = await this.dbContext
                .Users
                .FirstAsync(u => u.Id.ToString() == UserId);


            UserViewModel userViewModel = new UserViewModel
            {
                Id = user.Id.ToString(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };

            return userViewModel;
        }
        public async Task EditUserDataAsync(UserViewModel UserViewModel, string userId)
        {
            ApplicationUser user = await this.dbContext
                .Users
                .FirstAsync(u => u.Id.ToString() == userId);

            user.FirstName= UserViewModel.FirstName;
            user.LastName= UserViewModel.LastName;
            user.Email= UserViewModel.Email;
            user.NormalizedEmail = UserViewModel.Email.ToUpper();
            user.NormalizedUserName = UserViewModel.Email.ToUpper();
            user.UserName = UserViewModel.Email;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task MakeWorkerAsync(WorkerFormModel workerFormModel)
        {
            Worker worker = new Worker()
            {
                PhoneNumber = workerFormModel.PhoneNumber,
                Position = workerFormModel.Position,
                UserId = Guid.Parse(workerFormModel.Id)
                
            };

            IdentityUserRole<Guid> userRole = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse(workerFormModel.RoleId),
                UserId = Guid.Parse(workerFormModel.Id)
            };

            Salary salary = new Salary()
            {
                WorkerId = worker.Id,
                NetSalary = (double)workerFormModel.Salary,
                ChangeDate = DateTime.Now,
            };

            await this.dbContext.AddAsync(worker);
            await this.dbContext.AddAsync(userRole);
            await this.dbContext.AddAsync(salary);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PersonalFileFormModel> GetPersonalInfoByUserId(string userId, int months)
        {
            Worker worker = await this.dbContext.Workers
                .Include(x => x.User)
                .FirstAsync(x => x.UserId.ToString() == userId);

            ICollection<Salary> LastUserSalary = await this.dbContext.Salaries
                .Where(s => s.WorkerId.ToString() == worker.Id.ToString())
                .OrderByDescending(x => x.ChangeDate)
                .ToListAsync();

            PersonalFileFormModel personalFileFormModel = new PersonalFileFormModel()
            {
                userId= userId,
                Name = $"{worker.User.FirstName} {worker.User.LastName}",
                Salary = LastUserSalary.FirstOrDefault().NetSalary,
                SalaryUpdates = LastUserSalary.Count() - 1,
                Months = months
			};

            return personalFileFormModel;
        }

        public async Task<IEnumerable<MonthlyProjectCount>> GetMontlyProjects(int months, string workerId)
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime CurrentDateMonthsAgo = CurrentDate.AddMonths(-months);

            IEnumerable<GeoTask> tasks = await this.dbContext.GeoTasks
                .Where(x => x.CreateDate >= CurrentDateMonthsAgo && x.CreateDate <= CurrentDate && x.WorkerId.ToString() == workerId)
                .ToArrayAsync();

			List<MonthlyProjectCount> monthlyCounts = new List<MonthlyProjectCount>();

			for (int i = 0; i < months; i++)
			{
                int month = CurrentDate.AddMonths(-i).Month;
                int year = CurrentDate.AddMonths(-i).Year;
				IEnumerable<GeoTask> taskForMonth = tasks.Where(x => x.CreateDate.Month == month && x.CreateDate.Year == year);

                int tastkCounter = taskForMonth.Count();
                decimal tasksSumPrice = taskForMonth.Sum(x => x.Price);
				string monthName = CurrentDate.AddMonths(-i).ToString("MMMM-yyyy");
                
                MonthlyProjectCount monthlyProjectCount= new MonthlyProjectCount()
                {
                    Price = tasksSumPrice,
                    MonthName= monthName,
                    ProjectCount= tastkCounter
                };

				monthlyCounts.Add(monthlyProjectCount);
			}
            monthlyCounts.Reverse();
            IEnumerable<MonthlyProjectCount> projectCounts = monthlyCounts.ToArray();

            return projectCounts;

        }

		public async Task<IEnumerable<TypeProjectCount>> GetTypeProjectCounts(int months, string workerId)
		{
			DateTime CurrentDate = DateTime.Now;
			DateTime CurrentDateMonthsAgo = CurrentDate.AddMonths(-months);

			IEnumerable<GeoTask> tasks = await this.dbContext.GeoTasks
                .Include(x => x.Type)
				.Where(x => x.CreateDate >= CurrentDateMonthsAgo && x.CreateDate <= CurrentDate && x.WorkerId.ToString() == workerId)
				.ToArrayAsync();

            List<string> typeNames = await this.dbContext.Types
                .Select(x => x.Name).ToListAsync();

            List<TypeProjectCount> typeProjectCountsList = new List<TypeProjectCount>();

            foreach (string typeName in typeNames)
            {
                int projectCount = tasks.Where(x => x.Type.Name == typeName).Count();

                TypeProjectCount typeProjectCount = new TypeProjectCount()
                {
                    ProjectCount = projectCount,
                    Type = typeName
                };
                typeProjectCountsList.Add(typeProjectCount);
            }

            IEnumerable<TypeProjectCount> typeProjectCounts = typeProjectCountsList.ToArray();

            return typeProjectCounts;
		}
	}
}
