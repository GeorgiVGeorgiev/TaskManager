namespace TaskManager.Web.ViewModels.FrontDescriptionType
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.FrontDescriptionType;

    public class FrontDescriptionTypeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(TitleMaxLength,MinimumLength =TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength,MinimumLength =DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int TermDays { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
