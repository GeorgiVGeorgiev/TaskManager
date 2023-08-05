namespace TaskManager.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.EntityValidationConstants.Request;
    public class Request
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set;} = null!;

        [Required]
        public bool IsApproved { get; set; } = false;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
    }
}
