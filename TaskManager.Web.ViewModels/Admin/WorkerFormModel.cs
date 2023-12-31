namespace TaskManager.Web.ViewModels.Admin
{
    using System.ComponentModel.DataAnnotations;
    using TaskManager.Web.ViewModels.User;
    using static Common.EntityValidationConstants.Worker;
    using static Common.ErrorMessageBulgarian;
    public class WorkerFormModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Phone]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength,ErrorMessage =PhoneErrorMessage)]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(PositionMaxLength, MinimumLength = PositionMinLength, ErrorMessage =NameErrorMessage)]
        [Display(Name = "Позиция")]
        public string Position { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, int.MaxValue, ErrorMessage = SalaryErrorMessage)]
        [Display(Name = "Заплата")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name ="Роля")]
        public string RoleId { get; set; } = null!;
        public IEnumerable<RolesViewModel> Roles { get; set; } = new List<RolesViewModel>();
    }
}
