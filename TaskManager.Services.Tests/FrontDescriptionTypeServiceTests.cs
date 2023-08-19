using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Services.Data.Interfaces;
using TaskManager.Services.Data;
using TaskManager.Web.ViewModels.FrontDescriptionType;
using TaskManager.Web.ViewModels.Client;
using TaskManager.Data.Models;

namespace TaskManager.Services.Tests
{
    public class FrontDescriptionTypeServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IFrontDescriptionTypeService frontDescriptionTypeService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.frontDescriptionTypeService = new FrontDescriptionTypeService(this.dbContext);

        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllAsyncShoudReturnIEnumOfFrontDescriptionTypeViewModel()
        {

            IEnumerable<FrontDescriptionTypeViewModel> result = await this.frontDescriptionTypeService.GetAllAsync();

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(FrontDescriptionTypeViewModel));
            CollectionAssert.AllItemsAreNotNull(result);
            CollectionAssert.AllItemsAreUnique(result);
        }
        [Test]
        public async Task GetByIdAsyncShoudReturnFrontDescriptionTypeViewModel()
        {
            FrontDescriptionType frontDescriptionType = await dbContext.FrontDescriptionTypes
                .FirstAsync();
            int frontDescriptionTypeId = frontDescriptionType.Id;

            FrontDescriptionTypeViewModel result = await this.frontDescriptionTypeService.GetByIdAsync(frontDescriptionTypeId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(FrontDescriptionTypeViewModel)));
        }
        [Test]
        public async Task isExistByIdAsyncShoudReturnTrue()
        {
            FrontDescriptionType frontDescriptionType = await dbContext.FrontDescriptionTypes
                  .FirstAsync();
            int frontDescriptionTypeId = frontDescriptionType.Id;

            bool result = await this.frontDescriptionTypeService.isExistByIdAsync(frontDescriptionTypeId);

            Assert.IsTrue(result);
        }
        [Test]
        public async Task isExistByIdAsyncShoudReturnFalse()
        {
            FrontDescriptionType frontDescriptionType = await dbContext.FrontDescriptionTypes
                  .FirstAsync();
            int frontDescriptionTypeId = int.MaxValue;

            bool result = await this.frontDescriptionTypeService.isExistByIdAsync(frontDescriptionTypeId);

            Assert.IsFalse(result);
        }
    }
}
