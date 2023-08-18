namespace TaskManager.Web.ViewModels.GeoTask
{
    using System.ComponentModel.DataAnnotations;
    using TaskManager.Web.ViewModels.Admin;
    using TaskManager.Web.ViewModels.Client;
    using TaskManager.Web.ViewModels.Comentar;
    using TaskManager.Web.ViewModels.Status;
    using TaskManager.Web.ViewModels.Type;
    using TaskManager.Web.ViewModels.Worker;
    using static Common.EntityValidationConstants.GeoTask;
    using static Common.ErrorMessageBulgarian;

    public class EditGeoTaskViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(AddressMaxLength,MinimumLength =AddressMinLength,ErrorMessage =NameErrorMessage)]
        [Display(Name ="Адрес")]
        public string Adrress { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int ProjectNumber { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0,int.MaxValue,ErrorMessage =PriceErrorMessage)]
        [Display(Name ="Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime EndDate { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(IdKKKRMaxLength,MinimumLength =IdKKKRMinLength,ErrorMessage =NameErrorMessage)]
        public string IdKKKR { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(0,int.MaxValue)]
        public int quantity { get; set; } = 1;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NoteMaxLength,MinimumLength =NoteMinLength,ErrorMessage =NameErrorMessage)]
        public string Note { get; set; } = "";


        [Required]
        public string ClientId { get; set; } = null!;
        [Required]
        public IEnumerable<ClientViewModel> Clients { get; set; } = new List<ClientViewModel>();

        [Required]
        public string WorkerId { get; set; } = null!;
        [Required]
        public IEnumerable<AllWorkersViewModel> Workers { get; set; } = new List<AllWorkersViewModel>();

        [Required]
        public string CheckerId { get; set; } = null!;

        [Required]
        public IEnumerable<AllWorkersViewModel> Checkers { get; set; } = new List<AllWorkersViewModel>();

        [Required]
        public int StatusId { get; set; }

        [Required]
        public IEnumerable<StatusViewModel> Statuses { get; set; } = new List<StatusViewModel>();

        [Required]
        public int TypeId { get; set; }

        [Required]
        public IEnumerable<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();

        [Required]
        public IEnumerable<ComentarViewModel> Comentars { get; set; } = new List<ComentarViewModel>();
    }
}
