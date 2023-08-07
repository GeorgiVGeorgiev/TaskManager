namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
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
    }
}
