namespace TaskManager.Web.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.User;

    public class AllWorkersViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required]
        [Phone]
        public string PhoneNumer { get; set; } = null!;

        [Required]
        public string Position { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
    }
}
