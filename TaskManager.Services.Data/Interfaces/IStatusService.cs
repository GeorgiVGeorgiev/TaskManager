using TaskManager.Web.ViewModels.Status;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusViewModel>> GetAllStatusAsync();
    }
}
