namespace TaskManager.Web.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.User;
    using static Common.ErrorMessageBulgarian;

    public class UserViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [Display(Name = "Име")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; } = null!;
    }
}
