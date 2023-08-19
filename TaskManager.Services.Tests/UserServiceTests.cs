namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Admin;
    using static GenerateAdminSeed;

    public class UserServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IUserService userService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();
            AdminRoleSeed(this.dbContext);
            this.userService = new UserService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task IsUserWorkerByIdAsyncShoudReturnTrue()
        {
            Worker worker = await this.dbContext.Workers.FirstAsync();
            string userId = worker.UserId.ToString();

            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(userId);

            Assert.IsTrue(isUserWorker);
        }
        [Test]
        public async Task IsUserWorkerByIdAsyncShoudReturnFalse()
        {
            Worker worker = await this.dbContext.Workers.FirstAsync();
            string userId = worker.UserId.ToString() + "tr";

            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(userId);

            Assert.IsFalse(isUserWorker);
        }
        [Test]
        public async Task GetFullNameByEmailAsyncAsyncShoudReturnFullNameString()
        {
            ApplicationUser user = await this.dbContext.Users.FirstAsync();
            string userEmail = user.Email;

            string FullName = await this.userService.GetFullNameByEmailAsync(userEmail);

            Assert.That(FullName, Is.EqualTo($"{user.FirstName} {user.LastName}"));
            Assert.That(FullName.GetType(),Is.EqualTo(typeof(string)));
        }
        [Test]
        public async Task IsUserAdminByIdAsyncShoudReturnTrue()
        {
            var adminRole = await this.dbContext
                .Roles
                .FirstAsync(r => r.Name== "Administrator");
            string adminRoleId = adminRole.Id.ToString();

            var userRole = await this.dbContext
                .UserRoles
                .FirstAsync(ur => ur.RoleId.ToString() == adminRoleId);

            string adminUserId = userRole.UserId.ToString();

            bool isUserAdmin = await this.userService.IsUserAdminByIdAsync(adminUserId);

            Assert.IsTrue(isUserAdmin);
        }
        [Test]
        public async Task IsUserAdminByIdAsyncShoudReturnFalse()
        {
            var adminRole = await this.dbContext
                .Roles
                .FirstAsync(r => r.Name == "Administrator");
            string adminRoleId = adminRole.Id.ToString();

            var userRole = await this.dbContext
                .UserRoles
                .FirstAsync(ur => ur.RoleId.ToString() == adminRoleId);

            string adminUserId = userRole.UserId.ToString() + "tr";

            bool isUserAdmin = await this.userService.IsUserAdminByIdAsync(adminUserId);

            Assert.IsFalse(isUserAdmin);
        }
        [Test]
        public async Task IsUserExistByIdAsyncShoudReturnTrue()
        {
            ApplicationUser user = await this.dbContext.Users.FirstAsync();
            string userId = user.Id.ToString();

            bool isUserWorker = await this.userService.IsUserExistByIdAsync(userId);

            Assert.IsTrue(isUserWorker);

        }
        [Test]
        public async Task IsUserExistByIdAsyncShoudReturnFalse()
        {
            ApplicationUser user = await this.dbContext.Users.FirstAsync();
            string userId = user.Id.ToString() + "tr";

            bool isUserWorker = await this.userService.IsUserExistByIdAsync(userId);

            Assert.IsFalse(isUserWorker);

        }
        [Test]
        public async Task GetAllWorkersAsyncShoudReturnIEnumOfAllWorkersViewModel()
        {

            IEnumerable<AllWorkersViewModel> typeViewModels = await this.userService.GetAllWorkersAsync();

            CollectionAssert.AllItemsAreInstancesOfType(typeViewModels, typeof(AllWorkersViewModel));
            CollectionAssert.AllItemsAreNotNull(typeViewModels);
            CollectionAssert.AllItemsAreUnique(typeViewModels);
        }
        public async Task GetWorkerIdByUserIdAsyncShoudReturnWorkerIdString()
        {
            Worker worker = await this.dbContext.Workers.FirstAsync();
            string userId = worker.UserId.ToString();
            string workerId = worker.Id.ToString();

            string result = await this.userService.GetWorkerIdByUserIdAsync(userId);

            Assert.That(result.GetType(), Is.EqualTo(typeof(string)));
            Assert.True(result.Equals(workerId));
        }
    }
}