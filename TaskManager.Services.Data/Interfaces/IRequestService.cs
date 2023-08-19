namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Request;

    public interface IRequestService
    {
        public  Task SendRequestAsync(CreateRequestFormModel request, string userId);

        public Task<IEnumerable<RequestViewModel>> GetAllRequestAsync();

        public Task<RequestViewModel> GetRequestByIdAsync(string rquestId);

        public Task<bool> IsRequestExistByIdAsync(string requstId);

        public Task TaskIsAcceptByIdAsync(string taskId);
    }
}
