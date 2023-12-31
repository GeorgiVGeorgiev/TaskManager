using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Data.Configurations
{
    public class AspNetRolesEntityConfigurations : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(GenerateRoles());
        }

        private IdentityRole<Guid>[] GenerateRoles()
        {
            ICollection<IdentityRole<Guid>> roles = new List<IdentityRole<Guid>>();

            IdentityRole<Guid> role = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("2B37CCC1-0B8E-412E-9C23-617A75F35BE6"),
                Name = "Worker",
                NormalizedName = "WORKER",
                ConcurrencyStamp = "E98C6623-AF8C-46E9-9509-C4E0B4809E7A"
            };
            roles.Add(role);
            return roles.ToArray();
        }



    }
}
