using TaskManager.Web.ViewModels.Admin;
using TaskManager.Web.ViewModels.User;
using TaskManager.Web.ViewModels.Worker;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string Email);
        Task<bool> IsUserWorkerByIdAsync(string userId);
        Task<bool> IsUserAdminByIdAsync(string userId);
        Task<bool> IsUserExistByIdAsync(string userId);
        public Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync();
        public Task<IEnumerable<AllCheckerViewModel>> GetAllCheckersAsync();
        public Task<string> GetWorkerIdByUserIdAsync(string userId);
        public Task<IEnumerable<RolesViewModel>> GetAllRolesAsync();

    }
}
