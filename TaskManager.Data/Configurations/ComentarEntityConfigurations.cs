namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    public class ComentarEntityConfigurations : IEntityTypeConfiguration<Comentar>
    {
        public void Configure(EntityTypeBuilder<Comentar> builder)
        {
            builder
                .HasOne(c => c.Task)
                .WithMany(t => t.Comentars)
                .HasForeignKey(c => c.TaskId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
