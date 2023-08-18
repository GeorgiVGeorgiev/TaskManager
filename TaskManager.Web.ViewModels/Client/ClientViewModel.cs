namespace TaskManager.Web.ViewModels.Client
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Client;

    public class ClientViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [StringLength(ClientNameMaxLength, MinimumLength = ClientNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CustomerRepresentativeNameMaxLength, MinimumLength = CustomerRepresentativeNameMinLength)]
        public string CustomerRepresentative { get; set; } = "Няма";

        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}
