namespace TaskManager.Services.Data
{
	using Microsoft.EntityFrameworkCore;
	using TaskManager.Data;
	using TaskManager.Data.Models;
	using TaskManager.Services.Data.Interfaces;
	using TaskManager.Web.ViewModels.Admin;

	public class WorkerService : IWorkerService
	{
		private readonly TaskManagerDbContext dbContext;

		public WorkerService(TaskManagerDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<AllWorkersViewModel> GetWorkerFromTaskWorkerId(string Id)
		{
			Worker worker = await this.dbContext
				.Workers
				.Include(w => w.User)
				.FirstAsync(w => w.Id.ToString() == Id);

			AllWorkersViewModel allWorkersViewModel = new AllWorkersViewModel()
			{
				Id = worker.Id.ToString(),
				FirstName = worker.User.FirstName,
				LastName = worker.User.LastName,
				PhoneNumer = worker.PhoneNumber,
				Email = worker.User.Email,
				Position = worker.Position,
				UserId = worker.UserId.ToString()
			};

			return allWorkersViewModel;
		}
	}
}
