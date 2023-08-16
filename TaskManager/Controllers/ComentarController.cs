namespace TaskManager.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using TaskManager.Services.Data.Interfaces;
	using TaskManager.Web.Infrastructure.Extentions;
	using TaskManager.Web.ViewModels.Comentar;
	using TaskManager.Web.ViewModels.GeoTask;
	using static Common.NotificationMessages;

	public class ComentarController : Controller
	{
		private readonly IUserService userService;
		private readonly IComentarService comentarService;
		private readonly IGeoTaskService geoTaskService;
		private readonly ITypeService typeService;
		private readonly IStatusService statusService;
		private readonly IClientService clientService;

		public ComentarController(IUserService userService, IComentarService comentarService, IGeoTaskService geoTaskService, ITypeService typeService, IStatusService statusService,IClientService clientService)
		{
			this.userService = userService;
			this.comentarService = comentarService;
			this.geoTaskService = geoTaskService;
			this.typeService= typeService;
			this.statusService = statusService;
			this.clientService = clientService;
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int Id)
		{
            string UserId = User.GetId();
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);
            bool isComentarExist = await this.comentarService.IsComentarExistById(Id);

            try
            {
                if (!isUserWorker)
                {
                    return this.ErrorIfUserIsNotWorker();
                }
                if (!isComentarExist)
                {
                    return this.ErrorIfComentarDosNotExist();
                }
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
			try
			{
				ComentarViewModel comentarViewModel = await this.comentarService.GetComentarByIdAsync(Id);
                return this.View(comentarViewModel);
            }
			catch (Exception)
			{
				this.GeneralError();
			}
			return this.GeneralError();
        }

		[HttpPost]
		public async Task<IActionResult> Edit(ComentarViewModel comentarViewModel)
		{
			string UserId = User.GetId();
			bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);
			bool isComentarExist = await this.comentarService.IsComentarExistById(comentarViewModel.Id);

			try
			{
				if(!isUserWorker)
				{
					return this.ErrorIfUserIsNotWorker();
				}
				if(!isComentarExist)
				{
					return this.ErrorIfComentarDosNotExist();
				}
			}
			catch (Exception)
			{
				return this.GeneralError();
			}
			try
			{
                bool isButtonEditt = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Editt";
                bool isButtonClose = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Close";

				if(isButtonEditt)
				{
                    await this.comentarService.EditComentarByTaskIdAsync(comentarViewModel);
                    string Id = await this.comentarService.GetTaskIdByComentarId(comentarViewModel.Id);
                    return RedirectToAction("Edit", "GeoTask", new { Id = Id });
                }
				else if (isButtonClose)
				{
                    string Id = await this.comentarService.GetTaskIdByComentarId(comentarViewModel.Id);
                    return RedirectToAction("Edit", "GeoTask", new { Id = Id });
                }
				else
				{
                    return this.GeneralError();
                }


            }
			catch (Exception)
			{
				return this.GeneralError();
			}
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
            string UserId = User.GetId();
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);

            try
            {
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
				/*                bool isButtonAdd = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Add";
								bool isButtonClose = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Close";

								if (isButtonAdd)
								{
									await this.comentarService.CreateComentarAsync(comentarViewModel, UserId);
									string Id = await this.comentarService.GetTaskIdByComentarId(comentarViewModel.Id);
									return RedirectToAction("Edit", "GeoTask", new { Id = Id });
								}
								else if (isButtonClose)
								{
									string Id = await this.comentarService.GetTaskIdByComentarId(comentarViewModel.Id);
									return RedirectToAction("Edit", "GeoTask", new { Id = Id });
								}
								else
								{
									return this.GeneralError();
								}*/
				return this.View();

            }
			catch (Exception)
			{
				return this.GeneralError();
			}
        }
		[HttpPost]
		public async Task<IActionResult> Add(ComentarViewModel comentarViewModel, string Id)
		{
            string UserId = User.GetId();
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);

            try
            {
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
				comentarViewModel.TaskId= Id;
				comentarViewModel.WorkerId= UserId;
				bool isButtonAdd = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Add";
				bool isButtonClose = Request.HttpContext.Request.Form.Keys.ToArray()[1].ToString() == "Close";

				if (isButtonAdd)
				{
					await this.comentarService.CreateComentarAsync(comentarViewModel, UserId);
					return RedirectToAction("Edit", "GeoTask", new { Id = Id });
				}
				else if (isButtonClose)
				{
					return RedirectToAction("Edit", "GeoTask", new { Id = Id });
				}
				else
				{
					return this.GeneralError();
				}

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

		private IActionResult ErrorIfUserIsNotWorker()
		{
			this.TempData[ErrorMessage] = "Страницата е предназначена за работници.";

			return RedirectToAction("Index", "Home");
		}
		private IActionResult ErrorIfComentarDosNotExist()
		{
			this.TempData[ErrorMessage] = "Коментарът не съществува!";

			return RedirectToAction("Index", "Home");
		}
		private IActionResult GeneralError()
		{
			this.TempData[ErrorMessage] = "Стана нещо, опитай пак или се свържи с администратор.";

			return RedirectToAction("Index", "Home");
		}
	}
}
