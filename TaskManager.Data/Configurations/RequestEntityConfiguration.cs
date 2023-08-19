namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    public class RequestEntityConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasData(this.GenerateData());
        }
        private Request[] GenerateData()
        {
            ICollection<Request> data = new List<Request>();

            Request request= new Request()
            {
                Description = "Искам да бъде извършено геодезическо заснемане за дървестна растителност.",
                Id= Guid.Parse("6BDFE00A-5AA3-4DD4-B8A5-C75569188EA7"),
                IsApproved= false,
                Name="Пенка Пенкова",
                PhoneNumber="0896666666",
                UserId=Guid.Parse("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de")
            };
            data.Add(request);
            request = new Request()
            {
                Description = "Искам да бъде извършено геодезическо заснемане на площ на Мазе и Таван.",
                Id = Guid.Parse("3A9ACC4A-688C-46BB-9A02-054953BFC726"),
                IsApproved = false,
                Name = "Ивка Иванова",
                PhoneNumber = "0896666666",
                UserId = Guid.Parse("296193d2-f02c-4410-b8fe-9eab4ffb4801")
            };
            data.Add(request);
            request = new Request()
            {
                Description = "Искам да бъде извършено геодезическо заснемане на площ на Апартамент.",
                Id = Guid.Parse("E9EEF419-F1C8-4880-841D-318D6C09CBF7"),
                IsApproved = false,
                Name = "Ивка Иванова",
                PhoneNumber = "0896666666",
                UserId = Guid.Parse("296193d2-f02c-4410-b8fe-9eab4ffb4801")
            };
            data.Add(request);
            request = new Request()
            {
                Description = "Искам да бъде извършено геодезическо заснемане по чл.19 от ЗУЗСО.",
                Id = Guid.Parse("9BE32474-42D4-40A3-A1EE-54FC07AAEBAB"),
                IsApproved = false,
                Name = "Пенка Пенкова",
                PhoneNumber = "0896666666",
                UserId = Guid.Parse("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de")
            };
            data.Add(request);

            return data.ToArray();
        }
    }
}
