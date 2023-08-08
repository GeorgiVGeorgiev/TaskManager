﻿namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Client;

    public interface IClientService
    {
        public Task<IEnumerable<ClientViewModel>> GetAllClientsAsync();

        public Task<ClientFormModel> GetClientFormByIdAsync(string Id);

        public Task AddClientAsync(ClientFormModel model);

        public Task EditClientAsnyc(ClientViewModel model, string clientId);

        public Task<bool> IsClientExitByIdAsync(string clientId);
    }
}
