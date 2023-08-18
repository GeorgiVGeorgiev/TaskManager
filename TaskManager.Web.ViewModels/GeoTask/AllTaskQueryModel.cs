namespace TaskManager.Web.ViewModels.GeoTask
{
    using System.ComponentModel.DataAnnotations;

    public class AllTaskQueryModel
    {
        [Display(Name ="Тип на задачата")]
        public string? Type { get; set; }

        [Display(Name = "Търсене")]
        public string? SearchString { get; set; }

        [Display(Name = "Задачи на страница")]
        public int TaskPerPage { get; set; } = 15;

        public int CurrentPage { get; set; } = 1;

        public int TotalTaskss { get; set; }

        public IEnumerable<string> Types { get; set; } = new List<string>();

        public IEnumerable<TaskViewModel> Tasks { get; set; } = new HashSet<TaskViewModel>();
    }
}
