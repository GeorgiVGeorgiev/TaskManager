using TaskManager.Web.ViewModels.Client;
using TaskManager.Web.ViewModels.Request;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IRequestService
    {
        public  Task SendRequestAsync(CreateRequestFormModel request, string userId);

        public Task<IEnumerable<RequestViewModel>> GetAllRequestAsync();

        public Task<RequestViewModel> GetRequestByIdAsync(string rquestId);

        public Task<bool> IsRequestExistByIdAsync(string requstId);
    }
}
