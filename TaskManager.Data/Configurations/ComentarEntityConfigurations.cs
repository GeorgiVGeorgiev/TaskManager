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

            builder.HasData(this.GenerateData());
        }
        private Comentar[] GenerateData()
        {
            ICollection<Comentar> comentars = new List<Comentar>();

            Comentar comentar = new Comentar()
            {
                Id = 1,
                Description = "Това е тестов коментар за първата задача. От проектант 1.",
                TaskId = Guid.Parse("88439927-1864-4962-9C31-D32E86F6EC0C"),
                WorkerId = Guid.Parse("ACDA7DA9-D7A0-4FD0-9ACA-F6000DA77582")
            };
			comentars.Add(comentar);

            comentar = new Comentar()
            {
				Id = 2,
				Description = "Това е втори тестов коментар за първата задача. От проектант 2.",
				TaskId = Guid.Parse("88439927-1864-4962-9C31-D32E86F6EC0C"),
				WorkerId = Guid.Parse("1702E507-B3FC-48A0-808D-D989BD8A4697")
			};
            comentars.Add(comentar);

			comentar = new Comentar()
			{
				Id = 3,
				Description = "Това е трети тестов коментар за първата задача. От Админ.",
				TaskId = Guid.Parse("88439927-1864-4962-9C31-D32E86F6EC0C"),
				WorkerId = Guid.Parse("A13C085F-4D96-4244-8EA4-607C4B6989F6")
			};
			comentars.Add(comentar);

			comentar = new Comentar()
			{
				Id = 4,
				Description = "Това е четвърти тестов коментар за първата задача. От Мерач.",
				TaskId = Guid.Parse("88439927-1864-4962-9C31-D32E86F6EC0C"),
				WorkerId = Guid.Parse("C6D1253B-2695-4A7F-98D5-A2A87EB3B97A")
			};
			comentars.Add(comentar);

			return comentars.ToArray();
        }
    }
}
