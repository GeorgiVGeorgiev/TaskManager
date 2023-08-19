namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Status;

    public class StatusServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IStatusService statusService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.statusService = new StatusService(this.dbContext);

        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllStatusAsyncShoudReturnIEnumOfStatusViewModel()
        {

            IEnumerable<StatusViewModel> statusViewModels = await this.statusService.GetAllStatusAsync();

            CollectionAssert.AllItemsAreInstancesOfType(statusViewModels, typeof(StatusViewModel));
            CollectionAssert.AllItemsAreNotNull(statusViewModels);
            CollectionAssert.AllItemsAreUnique(statusViewModels);
        }
    }
}