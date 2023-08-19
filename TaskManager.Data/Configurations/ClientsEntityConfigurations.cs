using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManager.Data.Models;

namespace TaskManager.Data.Configurations
{
    public class ClientsEntityConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasData(this.GenerateData());
        }
        private Client[] GenerateData()
        {
            ICollection<Client> clients = new List<Client>();

            Client client = new Client()
            {
                Id= Guid.Parse("4ADD1981-C1EB-4666-BBC4-9C954E6925F5"),
                CustomerRepresentative="Иван Петков",
                Name="Георги Петков",
                PhoneNumber="0895555555",
                Email="IvanPetkov@work.bg"
            };
            clients.Add(client);

            client = new Client()
            {
                Id = Guid.Parse("9153E1A7-1565-48FF-8EDF-9EDF26F5D26B"),
                CustomerRepresentative = "Сашо Иванов",
                Name = "Михаела Иванова",
                PhoneNumber = "0894444444",
                Email = "SashoIvanov@work.bg"
            };
            clients.Add(client);

            client = new Client()
            {
                Id = Guid.Parse("C3F9F394-3B6E-4F8A-A08E-820EA06E4C60"),
                CustomerRepresentative = "Петър Георгиев",
                Name = "Гергана Петрова",
                PhoneNumber = "0893333333",
                Email = "GerganaPetrova@work.bg"
            };
            clients.Add(client);

            client = new Client()
            {
                Id = Guid.Parse("56F03003-C382-4428-997F-A975D7846608"),
                CustomerRepresentative = "Владимир Иванов",
                Name = "Няма",
                PhoneNumber = "0892222222",
                Email = "GerganaPetrova@work.bg"
            };
            clients.Add(client);

            return clients.ToArray();
        }
    }
}
