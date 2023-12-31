namespace TaskManager.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Comentar;

    public class ComentarServiceTests
    {
        private DbContextOptions<TaskManagerDbContext> dbContextOptions;
        private TaskManagerDbContext dbContext;

        private IComentarService comentarService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbContextOptions = new DbContextOptionsBuilder<TaskManagerDbContext>().UseInMemoryDatabase("TaskManagerInMemory" + Guid.NewGuid().ToString()).Options;

            this.dbContext = new TaskManagerDbContext(this.dbContextOptions);
            this.dbContext.Database.EnsureCreated();

            this.comentarService = new ComentarService(this.dbContext);
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task ComentarExistByUserIdShoudReturnTrue()
        {
            Comentar comentar = await this.dbContext.Comentars.FirstAsync();
            int existComentarId = comentar.Id;

            bool result = await this.comentarService.IsComentarExistById(existComentarId);

            Assert.IsTrue(result);
        }
        [Test]
        public async Task ComentarExistByUserIdShoudReturnFalse()
        {
            int dontExistedComentar = int.MaxValue;

            bool result = await this.comentarService.IsComentarExistById(dontExistedComentar);

            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetComentarByIdAsyncShoudReturnComentarViewModel()
        {
            Comentar comentar = await this.dbContext.Comentars.FirstAsync();
            int existComentarId = comentar.Id;

            ComentarViewModel result = await this.comentarService.GetComentarByIdAsync(existComentarId);

            Assert.That(result.GetType(),Is.EqualTo(typeof(ComentarViewModel)));
            
        }

        [Test]
        public async Task GetComentarByTaskIdAsyncShoudReturnIEnumOfComentarViewModel()
        {
            GeoTask geoTask = await this.dbContext.GeoTasks.FirstAsync();
            string existGeoTaskId = geoTask.Id.ToString();

            IEnumerable<ComentarViewModel> result = await this.comentarService.GetComentarByTaskIdAsync(existGeoTaskId);

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(ComentarViewModel));
            CollectionAssert.AllItemsAreNotNull(result);
            CollectionAssert.AllItemsAreUnique(result);
        }
        [Test]
        public async Task GetTaskIdByComentarIdShoudReturnGeoTaskStringId()
        {
            Comentar comentar = await this.dbContext.Comentars.FirstAsync();
            int existComentarId = comentar.Id;

            string TaskId = await this.comentarService.GetTaskIdByComentarId(existComentarId);
            bool isGuild = Guid.TryParse(TaskId,out Guid guildId);

            Assert.That(TaskId.GetType(), Is.EqualTo(typeof(string)));
            Assert.IsTrue(isGuild);
        }
        [Test]
        public async Task IsUserOwnerOfTheCommentarByWorkerIdAsyncShoudReturnTrue()
        {
            Comentar comentar = await dbContext.Comentars.FirstAsync();

            int comentarId = comentar.Id;
            string workerId = comentar.WorkerId.ToString();

            bool result = await this.comentarService.IsUserOwnerOfTheCommentarByWorkerIdAsync(comentarId,workerId);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task IsUserOwnerOfTheCommentarByWorkerIdAsyncShoudReturnFalse()
        {
            Comentar comentar = await dbContext.Comentars.FirstAsync();

            int comentarId = comentar.Id;
            string workerId = comentar.WorkerId.ToString() + "tr";

            bool result = await this.comentarService.IsUserOwnerOfTheCommentarByWorkerIdAsync(comentarId, workerId);

            Assert.IsFalse(result);
        }
    }
}