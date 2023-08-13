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

    public class EditGeoTaskViewModel
    {
        [Required]
        public string Id { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Adrress { get; set; } = null!;

        [Required]
        public int ProjectNumber { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(IdKKKRMaxLength)]
        public string IdKKKR { get; set; } = null!;

        [Required]
        public int quantity { get; set; } = 1;

        [Required]
        [MaxLength(NoteMaxLength)]
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
