namespace TaskManager.Web.ViewModels.GeoTask
{
    public class AllGeoTaskFilteredAndPageServiceModel
    {
        public int TotalTasks { get; set; }

        public IEnumerable<TaskViewModel> Tasks { get; set; } = new HashSet<TaskViewModel>();
    }
}
