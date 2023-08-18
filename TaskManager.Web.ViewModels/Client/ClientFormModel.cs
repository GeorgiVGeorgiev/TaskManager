namespace TaskManager.Web.ViewModels.Client
{
    using Newtonsoft.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Client;
    using static Common.ErrorMessageBulgarian;

    public class ClientFormModel
    {

        [Required]
        [StringLength(ClientNameMaxLength,MinimumLength =ClientNameMinLength,ErrorMessage =NameErrorMessage)]
        [Display(Name ="Име")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CustomerRepresentativeNameMaxLength,MinimumLength =CustomerRepresentativeNameMinLength,ErrorMessage =NameErrorMessage)]
        [Display(Name = "Име на представител")]
        public string CustomerRepresentative { get; set; } = CustomerRepresentativeDefautValue;

        [Required]
        [StringLength(PhoneNumberMaxLength,MinimumLength =PhoneNumberMinLength,ErrorMessage =PhoneErrorMessage)]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;
    }
}
