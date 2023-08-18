namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.Comentar;
    public class Comentar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public Guid WorkerId { get; set; }

        [Required]
        [ForeignKey(nameof(WorkerId))]
        public Worker Worker { get; set; } = null!;

        [Required]
        public Guid TaskId { get; set; }

        [Required]
        [ForeignKey(nameof(TaskId))]
        public GeoTask Task { get; set; } = null!;

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;


    }
}
