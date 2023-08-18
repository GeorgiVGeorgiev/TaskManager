namespace TaskManager.Web.ViewModels.Type
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Type;
    using static Common.ErrorMessageBulgarian;
    public class TypeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,MinimumLength =NameMinLength)]
        [Display(Name ="Име на задачата")]
        public string Name { get; set; } = null!;
    }
}
