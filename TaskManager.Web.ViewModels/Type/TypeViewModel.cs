using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.ViewModels.Type
{
    public class TypeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
