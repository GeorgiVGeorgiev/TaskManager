using TaskManager.Web.ViewModels.Request;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IRequestService
    {
        public  Task SendRequestAsync(CreateRequestViewModel request, string userId);
    }
}
