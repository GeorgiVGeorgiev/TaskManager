namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    public class StatusEntityConfigurations : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder
                .HasData(this.GemerateData());
        }
        private Status[] GemerateData()
        {
            ICollection<Status> types = new List<Status>();

            Status type = new Status()
            {
                Id = 1,
                Name = "Нова"
            };
            types.Add(type);

            type = new Status()
            {
                Id = 2,
                Name = "В процес на изпълнение"
            };
            types.Add(type);

            type = new Status()
            {
                Id = 3,
                Name = "Приключена"
            };
            types.Add(type);

            return types.ToArray();
        }
    }
}
