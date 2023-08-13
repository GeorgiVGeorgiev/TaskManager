namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.GeoTask;
    public class GeoTask
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

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
        public Guid ClientId { get; set; }

        [Required]
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; } = null!;

        [Required]
        public Guid WorkerId { get; set; }

        [Required]
        [ForeignKey(nameof(WorkerId))]
        public Worker Worker { get; set; } = null!;

        [Required]
        public Guid CheckerId { get; set; }

        [Required]
        [ForeignKey(nameof(CheckerId))]
        public Worker CheckEr { get; set; } = null!;

        [Required]
        public int StatusId { get; set; }

        [Required]
        [ForeignKey(nameof(StatusId))]
        public Status Status { get; set; } = null!;

        [Required]
        public int TypeId { get; set; }

        [Required]
        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;



        public ICollection<Comentar>? Comentars { get; set; }
        public ICollection<Document>? Documents { get; set; }

    }
}
