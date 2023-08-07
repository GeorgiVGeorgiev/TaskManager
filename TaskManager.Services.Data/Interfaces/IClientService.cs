namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Client;

    public interface IClientService
    {
        public Task<IEnumerable<ClientViewModel>> GetAllClientsAsync();

        public Task<ClientFormModel> GetClientFormByIdAsync(string Id);
    }
}
