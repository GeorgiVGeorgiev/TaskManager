namespace TaskManager.Web.ViewModels.Comentar
{
    using System.ComponentModel.DataAnnotations;


    public class ComentarViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string WorkerId { get; set; } = null!;

        [Required]
        public string TaskId { get; set; } = null!;

		[Required]
        public string Description { get; set; } = null!;

        [Required]
        public string WorkerFullName { get; set; } = null!;

        [Required]
        public string CreateDate { get; set; } = null!;
    }
}