namespace TaskManager.Web.ViewModels.Type
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Type;
    public class TypeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength,MinimumLength =NameMinLength)]
        [Display(Name ="Име на задачата")]
        public string Name { get; set; } = null!;
    }
}
