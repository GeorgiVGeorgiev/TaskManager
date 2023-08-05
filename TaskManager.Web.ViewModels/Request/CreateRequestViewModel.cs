namespace TaskManager.Web.ViewModels.Request
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using System.Xml.Serialization;
    using static Common.EntityValidationConstants.Request;
    using static Common.ErrorMessageBulgarian;
    public class CreateRequestViewModel
    {
        [Required]
        [StringLength(NameMaxLength,MinimumLength =NameMinLength,ErrorMessage = NameErrorMessage)]
        [Display(Name ="Име")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength,ErrorMessage =PhoneErrorMessage)]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength,ErrorMessage =TaskDescriptionErrorMessage)]
        [Display(Name = "Описаните на задачата")]
        public string Description { get; set; } = null!;

    }
}
