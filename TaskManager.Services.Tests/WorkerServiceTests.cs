namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;


    public class WorkerServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IWorkerService workerService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.workerService = new WorkerService(this.dbContext);

        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetGeoTaskByIdAsyncShoudReturnEditGeoTaskViewModel()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string workerId = geoTask.WorkerId.ToString();

            AllWorkersViewModel result = await this.workerService.GetWorkerFromTaskWorkerId(workerId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(AllWorkersViewModel)));
        }
    }
}
/*public Task<AllWorkersViewModel> GetWorkerFromTaskWorkerId(string Id);*/