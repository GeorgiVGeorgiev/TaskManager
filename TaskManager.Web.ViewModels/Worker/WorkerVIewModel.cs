namespace TaskManager.Web.ViewModels.Worker
{
    using System.ComponentModel.DataAnnotations;

    public class WorkerVIewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;
    }
}
