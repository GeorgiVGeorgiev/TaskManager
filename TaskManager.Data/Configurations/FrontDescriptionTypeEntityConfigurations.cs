namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;
    public class FrontDescriptionTypeEntityConfigurations : IEntityTypeConfiguration<FrontDescriptionType>
    {
        public void Configure(EntityTypeBuilder<FrontDescriptionType> builder)
        {
            builder
                .Property(fd => fd.Price)
                .HasPrecision(18, 6);
        }
    }
}
