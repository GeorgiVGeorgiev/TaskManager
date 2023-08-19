
namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Client;


    public class ClientServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IClientService clientService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.clientService = new ClientService(this.dbContext);

        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllClientsAsyncShoudReturnIEnumOfClientViewModel()
        {

            IEnumerable<ClientViewModel> result = await this.clientService.GetAllClientsAsync();

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(ClientViewModel));
            CollectionAssert.AllItemsAreNotNull(result);
            CollectionAssert.AllItemsAreUnique(result);
        }
        [Test]
        public async Task GetClientByIdAsyncShoudReturnClientViewModel()
        {
            Client client = await dbContext.Clients
                .FirstAsync(a => a.Name != "client");
            string clientId = client.Id.ToString();

            ClientViewModel result = await this.clientService.GetClientByIdAsync(clientId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(ClientViewModel)));
        }
        [Test]
        public async Task GetClientFormByIdAsyncShoudReturnClientFormModel()
        {
            Client client = await dbContext.Clients
                .FirstAsync(a => a.Name != "client");
            string clientId = client.Id.ToString();

            ClientFormModel result = await this.clientService.GetClientFormByIdAsync(clientId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(ClientFormModel)));
        }
        [Test]
        public async Task IsClientExitByIdAsyncShoudReturnTrue()
        {
            Client client = await dbContext.Clients
                .FirstAsync(a => a.Name != "client");
            string clientId = client.Id.ToString();

            bool result = await this.clientService.IsClientExitByIdAsync(clientId);

            Assert.IsTrue(result);
        }
        [Test]
        public async Task IsClientExitByIdAsyncShoudReturnFalse()
        {
            Client client = await dbContext.Clients
                .FirstAsync(a => a.Name != "client");
            string clientId = client.Id.ToString() + "tr";

            bool result = await this.clientService.IsClientExitByIdAsync(clientId);

            Assert.IsFalse(result);
        }
        [Test]
        public async Task GetAllClientFilteredAsyncShoudReturnAllClientsFilteredANdPageServiceModel()
        {
            IEnumerable<ClientViewModel> clients = await this.clientService.GetAllClientsAsync();

            AllClientQueryModel queryModel = new AllClientQueryModel()
            {
                Client = clients,
                ClientPerPage= 5,
                CurrentPage= 1,
                SearchString = "string",
                TotalTaskss= 15,
            };

            AllClientsFilteredANdPageServiceModel result = await this.clientService.GetAllClientFilteredAsync(queryModel);

            Assert.That(result.GetType(), Is.EqualTo(typeof(AllClientsFilteredANdPageServiceModel)));
        }
    }
}