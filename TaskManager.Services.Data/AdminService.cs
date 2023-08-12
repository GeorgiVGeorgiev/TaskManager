namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;

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
                    Position= u.Position,
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

            await this.dbContext.AddAsync(worker);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
