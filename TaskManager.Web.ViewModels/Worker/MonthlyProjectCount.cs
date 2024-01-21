using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.ViewModels.Worker
{
    public class MonthlyProjectCount
    {
        [Required]
        public string MonthName { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int ProjectCount { get; set; }
    }
}
