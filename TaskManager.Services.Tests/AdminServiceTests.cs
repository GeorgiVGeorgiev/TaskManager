namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;

    using static GenerateAdminSeed;

    public class AdminServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IAdminService adminService;
        private IUserService userService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();
            AdminRoleSeed(this.dbContext);

            this.adminService = new AdminService(this.dbContext,userService);
        }

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllUsersAsyncShoudReturnIEnumOfUserViewModel()
        {
            //
            IEnumerable<UserViewModel> typeViewModels = await this.adminService.GetAllUsersAsync();

            //Assert
            CollectionAssert.AllItemsAreInstancesOfType(typeViewModels, typeof(UserViewModel));
            CollectionAssert.AllItemsAreNotNull(typeViewModels);
            CollectionAssert.AllItemsAreUnique(typeViewModels);
        }
        [Test]
        public async Task GetAllWorkersAsyncShoudReturnIEnumOfAllWorkersViewModel()
        {

            IEnumerable<AllWorkersViewModel> typeViewModels = await this.adminService.GetAllWorkersAsync();

            CollectionAssert.AllItemsAreInstancesOfType(typeViewModels, typeof(AllWorkersViewModel));
            CollectionAssert.AllItemsAreNotNull(typeViewModels);
            CollectionAssert.AllItemsAreUnique(typeViewModels);
        }
        [Test]
        public async Task GetUserByIdAsyncAsyncShoudReturnUserViewModel()
        {
            ApplicationUser user = await this.dbContext.Users.FirstAsync();
            string userId = user.Id.ToString();

            UserViewModel result = await this.adminService.GetUserByIdAsync(userId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(UserViewModel)));
        }

    }
}