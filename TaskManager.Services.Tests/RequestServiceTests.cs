namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Request;

    public class RequestServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IRequestService requestService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.requestService = new RequestService(this.dbContext);

        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllRequestAsyncShoudReturnIEnumOfRequestViewModel()
        {

            IEnumerable<RequestViewModel> requestViewModels = await this.requestService.GetAllRequestAsync();

            CollectionAssert.AllItemsAreInstancesOfType(requestViewModels, typeof(RequestViewModel));
            CollectionAssert.AllItemsAreNotNull(requestViewModels);
            CollectionAssert.AllItemsAreUnique(requestViewModels);
        }
        [Test]
        public async Task GetRequestByIdAsyncShoudReturnRequestViewModel()
        {
            Request request = await dbContext.Requests
                .FirstAsync();
            string requestId = request.Id.ToString();

            RequestViewModel result = await this.requestService.GetRequestByIdAsync(requestId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(RequestViewModel)));
        }
        [Test]
        public async Task IsRequestExistByIdAsyncShoudReturnRequestTrue()
        {
            Request request = await dbContext.Requests
                .FirstAsync();
            string requestId = request.Id.ToString();

            bool result = await this.requestService.IsRequestExistByIdAsync(requestId);

            Assert.IsTrue(result);
        }
        [Test]
        public async Task IsRequestExistByIdAsyncShoudReturnRequestFalse()
        {
            Request request = await dbContext.Requests
                .FirstAsync();
            string requestId = request.Id.ToString()+"tr";

            bool result = await this.requestService.IsRequestExistByIdAsync(requestId);

            Assert.IsFalse(result);
        }
    }
}