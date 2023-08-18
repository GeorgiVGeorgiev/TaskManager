namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Comentar;

    public class ComentarService : IComentarService
    {
        private readonly TaskManagerDbContext dbContext;

        public ComentarService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

		public async Task<IEnumerable<ComentarViewModel>> GetComentarByTaskIdAsync(string Id)
        {
            IEnumerable<ComentarViewModel> comentarViewModels = await this.dbContext
                .Comentars
                .Include(c => c.Worker)
                .Where(c => c.TaskId.ToString() == Id)
                .Select(c => new ComentarViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    TaskId = c.TaskId.ToString(),
                    WorkerId = c.WorkerId.ToString(),
                    WorkerFullName = $"{c.Worker.User.FirstName} {c.Worker.User.LastName}",
                })
                .OrderByDescending(c => c.Id)
                .ToArrayAsync();

            return comentarViewModels;
        }
		public async Task EditComentarByTaskIdAsync(ComentarViewModel comentarViewModel)
		{
            Comentar comentar = await this.dbContext
                .Comentars
                .FirstAsync(c => c.Id == comentarViewModel.Id);

            comentar.Description = comentarViewModel.Description;

            await this.dbContext.SaveChangesAsync();
		}

		public async Task<bool> IsComentarExistById(int comentarId)
		{
            return await this.dbContext
                .Comentars
                .AnyAsync(c => c.Id == comentarId);
		}

        public async Task<ComentarViewModel> GetComentarByIdAsync(int Id)
        {
            Comentar comentar = await this.dbContext
                .Comentars
                .FirstAsync(c => c.Id == Id);

            ComentarViewModel comentarViewModel = new ComentarViewModel()
            {
                Id = Id,
                Description = comentar.Description,
                TaskId = comentar.TaskId.ToString(),
            };

            return comentarViewModel;
        }

        public async Task<string> GetTaskIdByComentarId(int comentarId)
        {
            Comentar coment = await this.dbContext
                .Comentars
                .FirstAsync(c => c.Id == comentarId);

            return coment.TaskId.ToString();
        }

        public async Task CreateComentarAsync(ComentarViewModel comentarViewModel)
        {

            Comentar comentar = new Comentar()
            {
                Description = comentarViewModel.Description,
                TaskId = Guid.Parse(comentarViewModel.TaskId),
                WorkerId = Guid.Parse(comentarViewModel.WorkerId)
            };

            await this.dbContext.Comentars.AddAsync(comentar);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsUserOwnerOfTheCommentarByWorkerIdAsync(int comentarId, string workerId)
        {
            
            return await this.dbContext.Comentars.AnyAsync(c => c.WorkerId.ToString() == workerId && c.Id == comentarId);
        }
    }
}
