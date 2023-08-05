using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Data.Models
{
    public class Document
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public bool IsThere { get; set; } = false;

        public Guid TaskId { get; set; }

        [Required]
        [ForeignKey(nameof(TaskId))]
        public Task Task { get; set; } = null!;

    }
}
