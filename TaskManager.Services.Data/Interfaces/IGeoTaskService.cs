namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.GeoTask;

    public interface IGeoTaskService
    {
        public Task<IEnumerable<TaskViewModel>> GetAllGeoTaskAsync();
        public Task<AllGeoTaskFilteredAndPageServiceModel> GetAllGeoTaskFilteredAsync(AllTaskQueryModel allTaskQueryModel);
        public Task<EditGeoTaskViewModel> GetGeoTaskByIdAsync(string Id);

        public Task<bool> IsTaskExistByIdAsync(string Id);

        public Task EditGeoTaskByIdAsync(EditGeoTaskViewModel editGeoTaskViewModel);

        public Task<EditGeoTaskViewModel> AddNewTask();

        public Task<IEnumerable<TaskViewModel>> GetMyTaskByWorkerIdAsync(string workerId);
    }
}
