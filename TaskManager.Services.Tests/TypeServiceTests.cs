namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Request;
    using TaskManager.Web.ViewModels.Type;
    using Type = TaskManager.Data.Models.Type;
    public class TypeServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private ITypeService typeService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.typeService = new TypeService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllTypesAsyncShoudReturnIEnumOfTypeViewModel()
        {

            IEnumerable<TypeViewModel> typeViewModels = await this.typeService.GetAllTypesAsync();

            CollectionAssert.AllItemsAreInstancesOfType(typeViewModels, typeof(TypeViewModel));
            CollectionAssert.AllItemsAreNotNull(typeViewModels);
            CollectionAssert.AllItemsAreUnique(typeViewModels);
        }
        [Test]
        public async Task IsExistByIdAsyncShoudReturnTrue()
        {
            Type type = await this.dbContext.Types.FirstAsync();
            int typeId = type.Id;

            bool isExist = await this.typeService.IsExistByIdAsync(typeId);

            Assert.IsTrue(isExist);
        }
        [Test]
        public async Task IsExistByIdAsyncShoudReturnFalse()
        {
            Type type = await this.dbContext.Types.FirstAsync();
            int typeId = int.MaxValue;

            bool isExist = await this.typeService.IsExistByIdAsync(typeId);

            Assert.IsFalse(isExist);
        }
        [Test]
        public async Task GetAllTypeNamesAsyncShoudReturnIEnumOfString()
        {

            IEnumerable<string> typeViewModels = await this.typeService.GetAllTypeNamesAsync();

            CollectionAssert.AllItemsAreInstancesOfType(typeViewModels, typeof(string));
            CollectionAssert.AllItemsAreNotNull(typeViewModels);
            CollectionAssert.AllItemsAreUnique(typeViewModels);
        }
        public async Task GetByIdAsyncAsyncShoudReturnTypeViewModel()
        {
            Type type = await this.dbContext.Types.FirstAsync();
            int typeId = type.Id;

            TypeViewModel result = await this.typeService.GetByIdAsync(typeId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(TypeViewModel)));
        }
    }
}