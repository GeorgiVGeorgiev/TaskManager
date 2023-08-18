namespace TaskManager.Web.ViewModels.Comentar
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Comentar;
    using static Common.ErrorMessageBulgarian;

    public class ComentarViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string WorkerId { get; set; } = null!;

        [Required]
        public string TaskId { get; set; } = null!;

		[Required]
        [StringLength(DescriptionMaxLength,MinimumLength =DescriptionMinLength,ErrorMessage = DescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        [Required]
        public string WorkerFullName { get; set; } = null!;

        [Required]
        public string CreateDate { get; set; } = null!;
    }
}