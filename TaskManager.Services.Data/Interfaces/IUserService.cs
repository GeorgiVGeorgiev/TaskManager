using TaskManager.Web.ViewModels.Admin;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFullNameByEmailAsync(string Email);

        Task<bool> IsUserWorkerByIdAsync(string userId);
        Task<bool> IsUserAdminByIdAsync(string userId);
        Task<bool> IsUserExistByIdAsync(string userId);
        public Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync();
    }
}
