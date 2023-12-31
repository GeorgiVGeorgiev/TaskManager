﻿using TaskManager.Web.ViewModels.Admin;

namespace TaskManager.Services.Data.Interfaces
{
	public interface IWorkerService
	{
		public Task<AllWorkersViewModel> GetWorkerFromTaskWorkerId(string Id);
		public Task<string> GetWorkerFullNameByUserId(string Id);
	}
}
