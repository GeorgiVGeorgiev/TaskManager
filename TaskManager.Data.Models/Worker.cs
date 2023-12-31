namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Worker;
    public class Worker
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(PositionMaxLength)]
        public string Position { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        public ICollection<GeoTask> Tasks = new HashSet<GeoTask>();

        public ICollection<Salary> Salaries= new HashSet<Salary>();
    }
}
