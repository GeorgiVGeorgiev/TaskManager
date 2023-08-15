namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
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
                //.Include(w => w.)
                .Where(c => c.TaskId.ToString() == Id)
                .Select(c => new ComentarViewModel
                {
                    Id = c.Id,
                    Description = c.Description,
                    TaskId = c.TaskId.ToString(),
                    WorkerId = c.WorkerId.ToString(),
                    WorkerFullName = $"{c.Worker.User.FirstName} {c.Worker.User.LastName}",
                })
                .ToArrayAsync();

            return comentarViewModels;
        }

    }
}
