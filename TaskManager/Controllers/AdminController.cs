namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Admin;
    using static Common.NotificationMessages;

    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IUserService userService;
        public AdminController(IAdminService adminService, IUserService userService)
        {
            this.adminService = adminService;
            this.userService = userService;
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            bool isUsersAdmin = User.isAdmin();
            try
            {
                if(!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }

            IEnumerable<UserViewModel> usersViewModel = await this.adminService.GetAllUsersAsync();

            return View(usersViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> AllWorkers()
        {
            bool isUsersAdmin = User.isAdmin();
            try
            {
                if (!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }

            IEnumerable<AllWorkersViewModel> workersViewModel = await this.adminService.GetAllWorkersAsync();

            return View(workersViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> UsersEdit(string Id)
        {
            bool isUsersAdmin = User.isAdmin();
            bool isUserExist = await this.userService.IsUserExistByIdAsync(Id);
            try
            {
                if (!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
                if(!isUserExist)
                {
                    return ErrorIfUserDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }

            UserViewModel userViewModel = await this.adminService.GetUserByIdAsync(Id);

            return View(userViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UsersEdit(string Id, UserViewModel userViewModel)
        {
            bool isUsersAdmin = User.isAdmin();
            bool isUserExist = await this.userService.IsUserExistByIdAsync(Id);
            try
            {
                if (!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
                if (!isUserExist)
                {
                    return ErrorIfUserDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                await this.adminService.EditUserDataAsync(userViewModel, Id);

                return this.RedirectToAction("AllUsers", "Admin");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpGet]
        public async Task<IActionResult> MakeWorker()
        {
            bool isUsersAdmin = User.isAdmin();
            bool isUserExist = await this.userService.IsUserExistByIdAsync(User.GetId());
            try
            {
                if (!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
                if (!isUserExist)
                {
                    return ErrorIfUserDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                WorkerFormModel workerFormModel = new WorkerFormModel();
                return this.View(workerFormModel);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeWorker(WorkerFormModel workerFormModel)
        {
            bool isUsersAdmin = User.isAdmin();
            bool isUserExist = await this.userService.IsUserExistByIdAsync(User.GetId());
            try
            {
                if (!isUsersAdmin)
                {
                    return ErrorIfUserIsNotAdmin();
                }
                if (!isUserExist)
                {
                    return ErrorIfUserDontExist();
                }
            }
            catch (Exception)
            {
                return GeneralError();
            }
            try
            {
                await this.adminService.MakeWorkerAsync(workerFormModel);

                return this.RedirectToAction("AllWorkers", "Admin");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        private IActionResult ErrorIfUserIsNotAdmin()
        {
            this.TempData[ErrorMessage] = "Страницата е предназначена за работници.";

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfUserDontExist()
        {
            this.TempData[ErrorMessage] = "Страницата е предназначена за работници.";

            return RedirectToAction("Index", "Home");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = "Стана нещо, опитай пак или се свържи с администратор.";

            return RedirectToAction("Index", "Home");
        }
    }
}
