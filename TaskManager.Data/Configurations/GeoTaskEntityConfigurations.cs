namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;
    public class GeoTaskEntityConfigurations : IEntityTypeConfiguration<GeoTask>
    {
        public void Configure(EntityTypeBuilder<GeoTask> builder)
        {
            builder
                .HasOne(t => t.Client)
                .WithMany(c => c.GeoTasks)
                .HasForeignKey(t => t.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(t => t.Type)
                .WithMany(ty => ty.Tasks)
                .HasForeignKey(t => t.TypeId)
                .OnDelete(DeleteBehavior.Restrict);
/*
            builder
                .HasOne(t => t.Worker)
                .WithMany(w => w.Tasks)
                .HasForeignKey(t => t.WorkerId)
                .OnDelete(DeleteBehavior.Restrict);*/

            builder
                .HasOne(t => t.CheckEr)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CheckerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(p => p.Price)
                .HasPrecision(18, 6);

            builder
                .Property(p => p.quantity)
                .HasPrecision(18, 6);
        }
    }
}
