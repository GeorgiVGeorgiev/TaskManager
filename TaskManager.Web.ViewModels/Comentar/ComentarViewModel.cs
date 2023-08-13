namespace TaskManager.Web.ViewModels.Comentar
{
    using System.ComponentModel.DataAnnotations;


    public class ComentarViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = null!;
    }
}
