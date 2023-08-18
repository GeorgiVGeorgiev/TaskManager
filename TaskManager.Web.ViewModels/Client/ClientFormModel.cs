namespace TaskManager.Web.ViewModels.Client
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Client;

    public class ClientFormModel
    {

        [Required]
        [StringLength(ClientNameMaxLength,MinimumLength =ClientNameMinLength)]
        [Display(Name ="Име")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CustomerRepresentativeNameMaxLength,MinimumLength =CustomerRepresentativeNameMinLength)]
        [Display(Name = "Име на представител")]
        public string CustomerRepresentative { get; set; } = "Няма";

        [Required]
        [StringLength(PhoneNumberMaxLength,MinimumLength =PhoneNumberMinLength)]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;
    }
}
