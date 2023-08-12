namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.CustomAttributs;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Request;

    using static Common.NotificationMessages;

    [Authorize]
    //[CustomAuthorize]
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

            CreateRequestFormModel requst = new CreateRequestFormModel();

            return View(requst);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequest(CreateRequestFormModel forModel)
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

        [HttpGet]
        public async Task<IActionResult> All()
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                IEnumerable<RequestViewModel> viewModels = await this.requestService.GetAllRequestAsync();

                return View(viewModels);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(string Id)
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }

                bool isRequestExist = await this.requestService.IsRequestExistByIdAsync(Id);
                if (!isRequestExist)
                {
                    return ErrorIfRequestDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                RequestViewModel requestViewModel = await this.requestService.GetRequestByIdAsync(Id);
                
                return View(requestViewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }
        [HttpPost]
        public async Task<IActionResult> Details(string Id, RequestViewModel viewModel)
        {
            try
            {
                bool isUserWorker = await this.userService.IsUserWorkerByIdAsync(User.GetId());
                if (!isUserWorker)
                {
                    return ErrorIfUserIsNotWorker();
                }

                bool isRequestExist = await this.requestService.IsRequestExistByIdAsync(Id);
                if (!isRequestExist)
                {
                    return ErrorIfRequestDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                await this.requestService.TaskIsAcceptByIdAsync(Id);

                return this.RedirectToAction("All", "Request");
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = "Стана нещо, опитай пак или се свържи с администратор.";

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfRequestDontExist()
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
