using TaskManager.Web.ViewModels.Client;

namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Services.Data;
    using TaskManager.Web.ViewModels.Comentar;

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
        public async Task GetClientByIdAsyncShoudReturnIEnumOfClientViewModel()
        {
            string clientId = dbContext.Clients.FirstAsync().Id.ToString();

            ClientViewModel result = await this.clientService.GetClientByIdAsync(clientId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(ClientViewModel)));
        }
    }
}
/*
public Task<ClientViewModel> GetClientByIdAsync(string Id);
public Task<ClientFormModel> GetClientFormByIdAsync(string Id);
public Task AddClientAsync(ClientFormModel model);
public Task EditClientAsnyc(ClientViewModel model, string clientId);
public Task<bool> IsClientExitByIdAsync(string clientId);
public Task<AllClientsFilteredANdPageServiceModel> GetAllClientFilteredAsync(AllClientQueryModel allClientQueryModel);*/