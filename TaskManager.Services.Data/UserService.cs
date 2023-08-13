namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;

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
    }
}
