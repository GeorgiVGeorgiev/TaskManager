namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.GeoTask;

    public class GeoTaskServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IGeoTaskService geoTaskService;
        private ITypeService typeService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.geoTaskService = new GeoTaskService(this.dbContext);
            this.typeService = new TypeService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllGeoTaskFilteredAsyncShoudReturnAllGeoTaskFilteredAndPageServiceModel()
        {
            IEnumerable<TaskViewModel> geoTaskViewModels = await this.geoTaskService.GetAllGeoTaskAsync();
            IEnumerable<string> typeViewModels = await this.typeService.GetAllTypeNamesAsync();

            AllTaskQueryModel allTaskQueryModel = new AllTaskQueryModel()
            {
                CurrentPage= 1,
                SearchString="",
                TaskPerPage=10,
                Tasks=geoTaskViewModels,
                TotalTaskss=25,
                Types=typeViewModels,
            };

            AllGeoTaskFilteredAndPageServiceModel result = await this.geoTaskService.GetAllGeoTaskFilteredAsync(allTaskQueryModel);

            Assert.That(result.GetType(), Is.EqualTo(typeof(AllGeoTaskFilteredAndPageServiceModel)));
        }
        [Test]
        public async Task GetAllGeoTaskAsyncShoudReturnIEnumOfTaskViewModel()
        {
            IEnumerable<TaskViewModel> geoTaskViewModels = await this.geoTaskService.GetAllGeoTaskAsync();

            CollectionAssert.AllItemsAreInstancesOfType(geoTaskViewModels, typeof(TaskViewModel));
            CollectionAssert.AllItemsAreNotNull(geoTaskViewModels);
            CollectionAssert.AllItemsAreUnique(geoTaskViewModels);
        }
        [Test]
        public async Task GetGeoTaskByIdAsyncShoudReturnEditGeoTaskViewModel()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string geoTaskId = geoTask.Id.ToString();

            EditGeoTaskViewModel result = await this.geoTaskService.GetGeoTaskByIdAsync(geoTaskId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(EditGeoTaskViewModel)));
        }
        [Test]
        public async Task IsTaskExistByIdAsyncShoudReturnTrue()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string geoTaskId = geoTask.Id.ToString();

            bool result = await this.geoTaskService.IsTaskExistByIdAsync(geoTaskId);

            Assert.IsTrue(result);
        }
        [Test]
        public async Task IsTaskExistByIdAsyncShoudReturnFalse()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string geoTaskId = geoTask.Id.ToString()+"tr";

            bool result = await this.geoTaskService.IsTaskExistByIdAsync(geoTaskId);

            Assert.IsFalse(result);
        }
        [Test]
        public async Task GetMyTaskByWorkerIdAsyncShoudReturnIEnumOfTaskViewModel()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string workerId = geoTask.WorkerId.ToString();

            IEnumerable<TaskViewModel> geoTaskViewModels = await this.geoTaskService.GetMyTaskByWorkerIdAsync(workerId);

            CollectionAssert.AllItemsAreInstancesOfType(geoTaskViewModels, typeof(TaskViewModel));
            CollectionAssert.AllItemsAreNotNull(geoTaskViewModels);
            CollectionAssert.AllItemsAreUnique(geoTaskViewModels);
        }
    }

}