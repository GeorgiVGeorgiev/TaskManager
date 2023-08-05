namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    public class DocumentEntityConfigurations : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder
                .HasOne(d => d.Task)
                .WithMany(t => t.Documents)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
