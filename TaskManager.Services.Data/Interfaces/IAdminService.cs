﻿namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Admin;
    using TaskManager.Web.ViewModels.Worker;

    public interface IAdminService
    {
        public Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        public Task<IEnumerable<AllWorkersViewModel>> GetAllWorkersAsync();

        public Task<UserViewModel> GetUserByIdAsync(string UserId);

        public Task EditUserDataAsync(UserViewModel UserViewModel,string userId);

        public Task MakeWorkerAsync(WorkerFormModel workerFormModel);

        public Task<PersonalFileFormModel> GetPersonalInfoByUserId(string userId, int months);

        public Task<IEnumerable<MonthlyProjectCount>> GetMontlyProjects(int months, string workerId);

        public Task<IEnumerable<TypeProjectCount>> GetTypeProjectCounts(int months, string workerId);
    }
}
