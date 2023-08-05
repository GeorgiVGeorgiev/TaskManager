namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Status;
    public class Status
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<GeoTask> Tasks { get; set; } = new List<GeoTask>();

    }
}
