namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Admin;
    using TaskManager.Web.ViewModels.Worker;

    public interface IAdminService
    {
        public Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        public Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync();

        public Task<UserViewModel> GetUserByIdAsync(string UserId);
        public Task<WorkerVIewModel> GetUserWorkerByIdAsync(string userId);

        public Task EditUserDataAsync(UserViewModel UserViewModel,string userId);

        public Task MakeWorkerAsync(WorkerFormModel workerFormModel);

    }
}
