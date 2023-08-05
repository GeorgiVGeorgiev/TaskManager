using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data.Models;

namespace TaskManager.Data.Configurations
{
    public class TaskEntityConfiguration : IEntityTypeConfiguration<GeoTask>
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
        }
    }
}
