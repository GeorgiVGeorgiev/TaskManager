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

            builder
                .HasData(this.GenerateData());
        }
        private GeoTask[] GenerateData()
        {
            ICollection<GeoTask> geoTasks= new List<GeoTask>();

            GeoTask geoTask = new GeoTask()
            {
                Id = Guid.Parse("88439927-1864-4962-9C31-D32E86F6EC0C"),
                CreateDate = DateTime.Now,
                EndDate = DateTime.Now,
                IdKKKR = "68134.905.11",
                Adrress = "Надежда 1",
                ClientId = Guid.Parse("890C29D4-841A-490C-8B85-07AF2BA826FD"),
                WorkerId = Guid.Parse("ACDA7DA9-D7A0-4FD0-9ACA-F6000DA77582"),
                CheckerId = Guid.Parse("A13C085F-4D96-4244-8EA4-607C4B6989F6"),
                Price = 500,
                quantity = 2,
                Note = "Няма",
                StatusId=1,
                TypeId=3,
                ProjectNumber=1,
            };
            geoTasks.Add(geoTask);

			geoTask = new GeoTask()
			{
				Id = Guid.Parse("6E6DE662-426F-4FF2-9886-984FA1C46A81"),
				CreateDate = DateTime.Now,
				EndDate = DateTime.Now,
				IdKKKR = "68134.905.11",
				Adrress = "Надежда 1",
				ClientId = Guid.Parse("2016AA91-7B89-4524-92E1-3606CBDA65C8"),
				WorkerId = Guid.Parse("C6D1253B-2695-4A7F-98D5-A2A87EB3B97A"),
				CheckerId = Guid.Parse("A13C085F-4D96-4244-8EA4-607C4B6989F6"),
				Price = 250,
				quantity = 1,
				Note = "Няма",
				StatusId = 1,
				TypeId = 5,
				ProjectNumber = 2,
			};
			geoTasks.Add(geoTask);

            return geoTasks.ToArray();
		}
    }
}
