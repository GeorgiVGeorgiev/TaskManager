namespace TaskManager.Web.ViewModels.Client
{
    using System.ComponentModel.DataAnnotations;
    using TaskManager.Web.ViewModels.GeoTask;

    public class AllClientQueryModel
    {

        [Display(Name = "Търсене")]
        public string? SearchString { get; set; }

        [Display(Name = "Клиенти на страница")]
        public int ClientPerPage { get; set; } = 15;

        public int CurrentPage { get; set; } = 1;

        public int TotalTaskss { get; set; }

        public IEnumerable<ClientViewModel> Client { get; set; } = new HashSet<ClientViewModel>();
    }
}
