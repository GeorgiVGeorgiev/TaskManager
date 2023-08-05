namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Document;

    public class Document
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public bool IsThere { get; set; } = false;

        public Guid TaskId { get; set; }

        [Required]
        [ForeignKey(nameof(TaskId))]
        public GeoTask Task { get; set; } = null!;

    }
}
