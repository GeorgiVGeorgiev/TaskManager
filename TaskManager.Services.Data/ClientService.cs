namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Client;

    public class ClientService : IClientService
    {
        private readonly TaskManagerDbContext dbContext;
        public ClientService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ClientViewModel>> GetAllClientsAsync()
        {
            IEnumerable<ClientViewModel> clientViewModels = await dbContext
                .Clients
                .Select(c => new ClientViewModel
                {
                    Id = c.Id.ToString(),
                    Name = c.Name,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    Predstavitel = c.Predstavitel,
                })
                .OrderBy(c => c.Name)
                .ToArrayAsync();

            return clientViewModels;         
        }
    }
}
