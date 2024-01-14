namespace TaskManager.Services.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Globalization;
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

        public async Task<PersonalFileFormModel> GetPersonalInfoByUserId(string userId)
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
            };

            return personalFileFormModel;
        }

        public async Task<IEnumerable<MonthlyProjectCount>> GetMontlyProjects(int months)
        {
            DateTime CurrentDate = DateTime.Now;
            DateTime CurrentDateMonthsAgo = CurrentDate.AddMonths(-months);

            IEnumerable<GeoTask> tasks = await this.dbContext.GeoTasks
                .Where(x => x.CreateDate >= CurrentDateMonthsAgo && x.CreateDate <= CurrentDate)
                .ToArrayAsync();

            IEnumerable<MonthlyProjectCount> monthlyCounts = 
                tasks.GroupBy(x => x.CreateDate.Month)
                .Select(x => new MonthlyProjectCount
                {
                    MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.Key),
                    ProjectCount = x.Count(),
                    Date = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.Key)
                })
                .ToArray();

            return monthlyCounts;

        }
    }
}
