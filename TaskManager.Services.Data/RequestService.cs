namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Client;
    using TaskManager.Web.ViewModels.Request;

    public class RequestService : IRequestService
    {
        private readonly TaskManagerDbContext dbContext;
        public RequestService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // [ValidateInput(true)]
        public async Task SendRequestAsync(CreateRequestFormModel viewModel, string userId)
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
        public async Task<IEnumerable<RequestViewModel>> GetAllRequestAsync()
        {
            IEnumerable<RequestViewModel> requestViewModels = await this.dbContext
                .Requests
                .Where(r => r.IsApproved == false)
                .Select(r => new RequestViewModel()
                {
                    Id = r.Id.ToString(),
                    Name = r.Name,
                    PhoneNumber = r.PhoneNumber,
                    Description = r.Description,
                })
                .ToArrayAsync();

            return requestViewModels;

        }

        public async Task<RequestViewModel> GetRequestByIdAsync(string rquestId)
        {
            Request request = await this.dbContext
                .Requests
                .FirstAsync(r => r.Id.ToString() == rquestId);

            RequestViewModel viewModel = new RequestViewModel()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Description = request.Description,
                IsApproved = request.IsApproved,
            };

            return viewModel;

        }

        public async Task<bool> IsRequestExistByIdAsync(string requstId)
        {
            return await this.dbContext
                .Requests
                .AnyAsync(r => r.Id.ToString() == requstId);
        }

        public async Task TaskIsAcceptByIdAsync(string taskId)
        {
            Request task = await this.dbContext
                .Requests
                .FirstAsync(r => r.Id.ToString() == taskId);

            task.IsApproved= true;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
