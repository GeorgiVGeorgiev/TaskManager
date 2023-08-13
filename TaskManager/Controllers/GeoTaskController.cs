namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.GeoTask;
    using static Common.NotificationMessages;

    [Authorize]
    public class GeoTaskController : Controller
    {
        private readonly IUserService userService;
        private readonly IGeoTaskService geoTaskService;
        private readonly IComentarService comentarService;
        private readonly ITypeService typeService;
        private readonly IStatusService statusService;
        private readonly IClientService clientService;


        public GeoTaskController(IUserService userService, IGeoTaskService geoTaskService, IComentarService comentarService, ITypeService typeService, IStatusService statusService, IClientService clientService)
        {
            this.userService = userService;
            this.geoTaskService = geoTaskService;
            this.comentarService = comentarService;
            this.typeService = typeService;
            this.statusService = statusService;
            this.clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> AllTasks()
        {
            try
            {
                string Id = User.GetId();
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(Id);

                if (!isUserWorker)
                {
                    return this.ErrorIfUserIsNotWorker();
                }
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                IEnumerable<TaskViewModel> taskViewModels = await this.geoTaskService.GetAllGeoTaskAsync();

                return this.View(taskViewModels);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }

        }
        [HttpGet]
        public async Task<IActionResult> Edit(string Id)
        {
            try
            {
                string UserId = User.GetId();
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);
                bool isTaskExist = await this.geoTaskService.IsTaskExistByIdAsync(Id);
                if (!isUserWorker)
                {
                    return this.ErrorIfUserIsNotWorker();
                }
                if(!isTaskExist)
                {
                    return this.ErrorIfTaskDontExist();
                }
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                EditGeoTaskViewModel editGeoTaskViewModel = await this.geoTaskService.GetGeoTaskByIdAsync(Id);
                 
                editGeoTaskViewModel.Comentars = await this.comentarService.GetComentarByTaskIdAsync(Id);
                editGeoTaskViewModel.Types = await this.typeService.GetAllTypesAsync();
                editGeoTaskViewModel.Statuses = await this.statusService.GetAllStatusAsync();
                editGeoTaskViewModel.Checkers = await this.userService.GetAllWorkersAsync();
                editGeoTaskViewModel.Workers = await this.userService.GetAllWorkersAsync();
                editGeoTaskViewModel.Clients = await this.clientService.GetAllClientsAsync();

                return this.View(editGeoTaskViewModel);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpPost]
		public async Task<IActionResult> Edit(EditGeoTaskViewModel editGeoTaskViewModel)
        {
			try
			{
				string UserId = User.GetId();
				bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);
				bool isTaskExist = await this.geoTaskService.IsTaskExistByIdAsync(editGeoTaskViewModel.Id);

				if (!isUserWorker)
				{
					return this.ErrorIfUserIsNotWorker();
				}
				if (!isTaskExist)
				{
					return this.ErrorIfTaskDontExist();
				}
			}
			catch (Exception)
			{
				return this.GeneralError();
			}

            bool isButtonSaveAndClose = Request.HttpContext.Request.Form.Keys.ToArray()[0].ToString() == "SaveAndClose";
            bool isButtonSave = Request.HttpContext.Request.Form.Keys.ToArray()[0].ToString() == "Edit";

			if (isButtonSaveAndClose)
            {
                try
                {
					await this.geoTaskService.EditGeoTaskByIdAsync(editGeoTaskViewModel);
                    return this.RedirectToAction("AllTasks", "GeoTask");
				}
				catch (Exception)
                {
                    return this.GeneralError();
                }
            }
            else if (isButtonSave)
            {
                try
                {
					await this.geoTaskService.EditGeoTaskByIdAsync(editGeoTaskViewModel);

					EditGeoTaskViewModel editGeoTaskViewModelLoad = await this.geoTaskService.GetGeoTaskByIdAsync(editGeoTaskViewModel.Id);

					editGeoTaskViewModelLoad.Comentars = await this.comentarService.GetComentarByTaskIdAsync(editGeoTaskViewModel.Id);
					editGeoTaskViewModelLoad.Types = await this.typeService.GetAllTypesAsync();
					editGeoTaskViewModelLoad.Statuses = await this.statusService.GetAllStatusAsync();
					editGeoTaskViewModelLoad.Checkers = await this.userService.GetAllWorkersAsync();
					editGeoTaskViewModelLoad.Workers = await this.userService.GetAllWorkersAsync();
					editGeoTaskViewModelLoad.Clients = await this.clientService.GetAllClientsAsync();

					return this.View(editGeoTaskViewModelLoad);

				}
				catch (Exception)
                {
					return this.GeneralError();
				}
            }
            return GeneralError();
		}
        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = "Стана нещо, опитай пак или се свържи с администратор.";

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfTaskDontExist()
        {
            this.TempData[ErrorMessage] = "Задачата не съществува в базата данни.";

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfUserIsNotWorker()
        {
            this.TempData[ErrorMessage] = "Страницата е предназначена за работници.";

            return RedirectToAction("Index", "Home");
        }

    }
}
