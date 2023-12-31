namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;
    using TaskManager.Web.ViewModels.User;
    using TaskManager.Web.ViewModels.Worker;

    public class UserService : IUserService
    {
        private readonly TaskManagerDbContext dbContext;

        public UserService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<string> GetFullNameByEmailAsync(string Email)
        {
            ApplicationUser? user = await this.dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == Email);

            if (user == null)
            {
                return string.Empty;
            }

            return $"{user.FirstName} {user.LastName}";

        }

        public async Task<bool> IsUserWorkerByIdAsync(string userId)
        {
            return await this.dbContext
                .Workers
                .AnyAsync(u => u.UserId.ToString() == userId);
        }
        public async Task<bool> IsUserAdminByIdAsync(string userId)
        {
            return await this.dbContext
                .UserRoles
                .AnyAsync(a => a.UserId.ToString() == userId);
        }

        public async Task<bool> IsUserExistByIdAsync(string userId)
        {
            return await this.dbContext
                 .Users
                 .AnyAsync(a => a.Id.ToString() == userId);
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

        public async Task<string> GetWorkerIdByUserIdAsync(string userId)
        {
            Worker worker = await this.dbContext.Workers.FirstAsync(w => w.UserId.ToString() == userId);

            return worker.Id.ToString();


        }

        public async Task<IEnumerable<AllCheckerViewModel>> GetAllCheckersAsync()
        {
            IEnumerable<AllCheckerViewModel> workers = await this.dbContext
                .Workers
                .Include(w => w.User)
                .Select(u => new AllCheckerViewModel
                {
                    Id=u.User.Id.ToString(),
                    FirstName = u.User.FirstName,
                    LastName = u.User.LastName,
                })
                .ToArrayAsync();

            return workers;
        }

        public async Task<IEnumerable<RolesViewModel>> GetAllRolesAsync()
        {
            IEnumerable<RolesViewModel> roles = await this.dbContext
                .Roles
                .Select(r => new RolesViewModel()
                {
                    Id = r.Id.ToString(),
                    Name = r.Name,
                })
                .ToArrayAsync();

            return roles;
        }
    }
}
