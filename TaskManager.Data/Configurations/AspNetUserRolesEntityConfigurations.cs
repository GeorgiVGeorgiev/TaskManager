using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManager.Data.Configurations
{
    public class AspNetUserRolesEntityConfigurations : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(GenerateIdentityUserRole());
        }

        IdentityUserRole<Guid>[] GenerateIdentityUserRole()
        {
            ICollection<IdentityUserRole<Guid>> identityUserRoles= new HashSet<IdentityUserRole<Guid>>();

            IdentityUserRole<Guid> identityUserRole = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("2B37CCC1-0B8E-412E-9C23-617A75F35BE6"),
                UserId = Guid.Parse("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
            };
            identityUserRoles.Add(identityUserRole);

            identityUserRole = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("2B37CCC1-0B8E-412E-9C23-617A75F35BE6"),
                UserId = Guid.Parse("6cef6e21-5151-4e88-be5c-f4f78953bf84")
            };
            identityUserRoles.Add(identityUserRole);

            return identityUserRoles.ToArray();
        }
    }
}
