namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Admin;

    public interface IAdminService
    {
        public Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        public Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync();

        public Task<UserViewModel> GetUserByIdAsync(string UserId);

        public Task EditUserDataAsync(UserViewModel UserViewModel,string userId);

        public Task MakeWorkerAsync(WorkerFormModel workerFormModel);

    }
}
