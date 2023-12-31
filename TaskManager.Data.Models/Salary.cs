using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Data.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double NetSalary { get; set; }

        [Required]
        public DateTime ChangeDate { get; set; } = DateTime.Now;

        [Required]
        public Guid WorkerId { get; set; }

        [Required]
        [ForeignKey(nameof(WorkerId))]
        public Worker Worker { get; set; } = null!;
    }
}
