namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Status;

    public class StatusService : IStatusService
    {
        private readonly TaskManagerDbContext dbContext;

        public StatusService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<StatusViewModel>> GetAllStatusAsync()
        {
            IEnumerable<StatusViewModel> viewModel = await this.dbContext
                .Statuses
                .Select(s => new StatusViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToArrayAsync();

            return viewModel;
        }
    }
}
