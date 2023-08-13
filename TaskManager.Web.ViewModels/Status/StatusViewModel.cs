namespace TaskManager.Web.ViewModels.Status
{
    using System.ComponentModel.DataAnnotations;

    public class StatusViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
