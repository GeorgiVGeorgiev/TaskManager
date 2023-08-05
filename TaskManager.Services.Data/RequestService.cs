namespace TaskManager.Services.Data
{
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Request;

    public class RequestService : IRequestService
    {
        private readonly TaskManagerDbContext dbContext;
        public RequestService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SendRequestAsync(CreateRequestViewModel viewModel, string userId)
        {
            Request request = new Request()
            {
                Name = viewModel.Name,
                PhoneNumber = viewModel.PhoneNumber,
                Description = viewModel.Description,
                UserId = Guid.Parse(userId)
            };

            await this.dbContext.Requests.AddAsync(request);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
