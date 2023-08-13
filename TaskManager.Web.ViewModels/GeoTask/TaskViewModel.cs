namespace TaskManager.Web.ViewModels.GeoTask
{
    using System.ComponentModel.DataAnnotations;

    public class TaskViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public int Number { get; set; }

        [Required]
        public string status { get; set; } = null!;

        [Required]
        public string ClientName { get; set; } = null!;

        [Required]
        public string TaskType { get; set; } = null!;

        [Required]
        public int quantity { get; set; }

        [Required]
        public decimal price { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

    }
}
