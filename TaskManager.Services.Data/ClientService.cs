namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
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

        public async Task<ClientFormModel> GetClientFormByIdAsync(string Id)
        {
            Client formModel = await this.dbContext
                .Clients
                .FirstAsync(c => c.Id.ToString() == Id);

            return new ClientFormModel()
            {
                Name = formModel.Name,
                Email = formModel.Email,
                PhoneNumber = formModel.PhoneNumber,
                Predstavitel = formModel.Predstavitel,
            };
        }
        public async Task AddClientAsync(ClientFormModel model)
        {
            Client client = new Client()
            {
                Name = model.Name,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Predstavitel = model.Predstavitel,
            };
            await this.dbContext
                .Clients.AddAsync(client);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditClientAsnyc(ClientViewModel model, string clientId)
        {
            Client client = await this.dbContext
                .Clients
                .FirstAsync(c => c.Id.ToString() == clientId);

            client.Name = model.Name;
            client.Email = model.Email;
            client.PhoneNumber = model.PhoneNumber;
            client.Predstavitel = model.Predstavitel;


            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsClientExitByIdAsync(string clientId)
        {
            return await this.dbContext
                .Clients
                .AnyAsync(c => c.Id.ToString() == clientId);
        }

        public async Task<ClientViewModel> GetClientByIdAsync(string Id)
        {
            Client client = await this.dbContext
                .Clients
                .FirstAsync(c => c.Id.ToString() == Id);
            return new ClientViewModel()
            {
                Id = client.Id.ToString(),
                Name = client.Name,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber,
                Predstavitel = client.Predstavitel,
            };
        }
    }
}
