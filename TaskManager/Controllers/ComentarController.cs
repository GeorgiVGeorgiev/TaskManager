namespace TaskManager.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using TaskManager.Services.Data.Interfaces;
	using TaskManager.Web.Infrastructure.Extentions;
	using TaskManager.Web.ViewModels.Comentar;

	public class ComentarController : Controller
	{
		private readonly IUserService userService;
		public ComentarController(IUserService userService)
		{
			this.userService = userService;
		}

		public async Task<IActionResult> Edit(ComentarViewModel comentarViewModel)
		{
			string UserId = User.GetId();
			bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(UserId);

			return Ok();
		}
	}
}
