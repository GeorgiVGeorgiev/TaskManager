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
        public RequestController(IRequestService requestService)
        {
            this.requestService = requestService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateRequest()
        {
            CreateRequestViewModel requst = new CreateRequestViewModel();

            return View(requst);
        }

        [HttpPost]
        //[vali]
        public async Task<IActionResult> CreateRequest(CreateRequestViewModel forModel)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Нещо не се обърка");
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
