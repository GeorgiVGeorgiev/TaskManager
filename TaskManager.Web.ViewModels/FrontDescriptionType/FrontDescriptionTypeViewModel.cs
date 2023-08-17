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
        [Display(Name ="Заглавие")]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength,MinimumLength =DescriptionMinLength)]
        [Display(Name = "Описание")]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Display(Name = "Image link")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Display(Name = "Работни дни")]
        [Range(0,365)]
        public int TermDays { get; set; }

        [Required]
        [Display(Name = "Цена")]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
