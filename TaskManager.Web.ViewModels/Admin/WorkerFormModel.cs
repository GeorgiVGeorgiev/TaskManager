namespace TaskManager.Web.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;
    using System.Security.Permissions;
    using static Common.EntityValidationConstants.Worker;

    public class WorkerFormModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [Phone]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength)]
        [Display(Name = "Позиция")]
        public string Position { get; set; } = null!;
    }
}
