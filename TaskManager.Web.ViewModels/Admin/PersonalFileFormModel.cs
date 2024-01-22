using System.ComponentModel.DataAnnotations;
using TaskManager.Web.ViewModels.Worker;

namespace TaskManager.Web.ViewModels.Admin
{
    using static Common.ErrorMessageBulgarian;
    using static Common.EntityValidationConstantView.PerosanlFileFormModel;
    public class PersonalFileFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public string userId { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,MinimumLength =NameMinLength,ErrorMessage =NameErrorMessage)]
        [Display(Name ="Име")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage =RequiredErrorMessage)]
        [Range(0, int.MaxValue, ErrorMessage = SalaryErrorMessage)]
        [Display(Name = "Заплата")]
        public double Salary { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0, int.MaxValue, ErrorMessage = SalaryErrorMessage)]
        [Display(Name = "Повишения")]
        public int SalaryUpdates { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(1, 36)]
        [Display(Name = "Месеци")]
        public int Months { get; set; } = 5;

        public IEnumerable<MonthlyProjectCount> monthlyProjectCounts { get; set; } = new HashSet<MonthlyProjectCount>();
        public IEnumerable<TypeProjectCount> typeProjectCounts { get; set; } = new HashSet<TypeProjectCount>();

	}
}
