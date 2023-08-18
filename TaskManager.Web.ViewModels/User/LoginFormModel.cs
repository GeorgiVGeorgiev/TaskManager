namespace TaskManager.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;
    using static Common.ErrorMessageBulgarian;

    public class LoginFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [Display(Name ="Имейл")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [DataType(DataType.Password)]
        [Display(Name ="Парола")]
        public string Password { get; set; } = null!;

        [Display(Name = "Запомни ме")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
