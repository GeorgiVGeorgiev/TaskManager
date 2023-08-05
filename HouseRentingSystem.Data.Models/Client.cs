namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidationConstants.Client;
    public class Client
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MaxLength(ClientNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(PredstavitelNameMaxLength)]
        public string Predstavitel { get; set; } = "Няма";

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public ICollection<GeoTask> GeoTasks { get; set; } = new HashSet<GeoTask>();

    }
}
