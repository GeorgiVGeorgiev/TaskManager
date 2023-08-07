namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Client;

    using static Common.NotificationMessages;

    [Authorize]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;
        private readonly IUserService userService;
        public ClientController(IClientService clientService, IUserService userService)
        {
            this.clientService = clientService;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Clients()
        {
            bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
            if (!isUserWorker)
            {
                return ErrorIfUserIsNotWorker();
            }
            IEnumerable<ClientViewModel> clientsViewModel = await this.clientService.GetAllClientsAsync()!;

            return View(clientsViewModel);
        }

        private IActionResult ErrorIfUserIsNotWorker()
        {

            this.TempData[ErrorMessage] = "Страницата е предназначена за работници.";

            return RedirectToAction("Index", "Home");
        }

    }
}
