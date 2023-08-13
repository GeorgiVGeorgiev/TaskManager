using TaskManager.Web.ViewModels.Admin;

namespace TaskManager.Services.Data.Interfaces
{
	public interface IWorkerService
	{
		public Task<AllWorkersViewModel> GetWorkerFromTask(string Id);
	}
}
