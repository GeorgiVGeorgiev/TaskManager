namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Admin;
    using static Common.NotificationMessages;
    using static Common.ErrorMessageBulgarian;
    using TaskManager.Web.ViewModels.User;

    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IUserService userService;
        private readonly IWorkerService workerService;
        public AdminController(IAdminService adminService, IUserService userService, IWorkerService workerService)
        {
            this.adminService = adminService;
            this.userService = userService;
            this.workerService= workerService;
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
                workerFormModel.Roles = await this.userService.GetAllRolesAsync();

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
                this.TempData[SuccsessMessage] = string.Format(SuccesfullyMakeUserWorker, $"{await this.workerService.GetWorkerFullNameByUserId(workerFormModel.Id)}");

                return this.RedirectToAction("AllWorkers", "Admin");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        private IActionResult ErrorIfUserIsNotAdmin()
        {
            this.TempData[ErrorMessage] = ErrorIfUserIsNotAdminMessage;

            return RedirectToAction("Index", "Home");
        }
        private IActionResult ErrorIfUserDontExist()
        {
            this.TempData[ErrorMessage] = ErrorIfUserDontExistMessage;

            return RedirectToAction("Index", "Home");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return RedirectToAction("Index", "Home");
        }
    }
}
