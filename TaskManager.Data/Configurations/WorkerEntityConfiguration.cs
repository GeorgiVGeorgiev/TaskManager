namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    public class WorkerEntityConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder
                .HasData(this.GenerateWorker());
        }
        private Worker[] GenerateWorker()
        {
            ICollection<Worker> workers = new List<Worker>();

            Worker worker = new Worker()
            {
                Id = Guid.Parse("a13c085f-4d96-4244-8ea4-607c4b6989f6"),
                PhoneNumber = "0899999999",
                Position = "Admin",
                UserId = Guid.Parse("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),

            };
            workers.Add(worker);

            worker = new Worker()
            {
                Id = Guid.Parse("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"),
                PhoneNumber = "0888888888",
                Position = "Мерач",
                UserId = Guid.Parse("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
            };
            workers.Add(worker);

            worker = new Worker()
            {
                Id = Guid.Parse("acda7da9-d7a0-4fd0-9aca-f6000da77582"),
                PhoneNumber = "0877777777",
                Position = "Проектант",
                UserId = Guid.Parse("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
            };
            workers.Add(worker);

            return workers.ToArray();
        }
    }
}
