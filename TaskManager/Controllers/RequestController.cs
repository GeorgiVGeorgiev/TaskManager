namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Request;

    using static Common.NotificationMessages;

    [Authorize]
    public class RequestController : Controller
    {
        private readonly IRequestService requestService;
        private readonly IUserService userService;
        public RequestController(IRequestService requestService, IUserService userService)
        {
            this.requestService = requestService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateRequest()
        {
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());

            if (isUserWorker)
            {
                TempData[WarningMessage] = "Ти работиш, какви задачи искаш да даваш?";
                return this.RedirectToAction("MyTasks", "Task");
            }

            CreateRequestViewModel requst = new CreateRequestViewModel();

            return View(requst);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(CreateRequestViewModel forModel)
        {
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());

            if (isUserWorker)
            {
                TempData[WarningMessage] = "Ти работиш, какви задачи искаш да даваш?";
                return this.RedirectToAction("MyTasks", "Task");
            }

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Нещо се обърка");
                return this.View(forModel);
            }
            try
            {
                 await this.requestService.SendRequestAsync(forModel, this.User.GetId());

            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Нещо не се получи с изпращането опитай пак");
                return this.View(forModel);
            }
            TempData[SuccsessMessage] = "Успешно изпратихте вашата заявка.";
            return RedirectToAction("Index", "Home");
        }
    }
}
