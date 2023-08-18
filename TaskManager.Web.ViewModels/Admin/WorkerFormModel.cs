namespace TaskManager.Web.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Worker;
    using static Common.ErrorMessageBulgarian;
    public class WorkerFormModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [Phone]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength,ErrorMessage =PhoneErrorMessage)]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength, ErrorMessage =NameErrorMessage)]
        [Display(Name = "Позиция")]
        public string Position { get; set; } = null!;
    }
}
