namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.FrontDescriptionType;
    using static Common.NotificationMessages;
    using static Common.ErrorMessageBulgarian;

    [Authorize(Roles ="Administrator")]
    public class FrontDescriptionController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IUserService userService;
        private readonly IFrontDescriptionTypeService frontDescriptionTypeService;
        public FrontDescriptionController(IAdminService adminService, IUserService userService, IFrontDescriptionTypeService frontDescriptionTypeService)
        {
            this.adminService = adminService;
            this.userService = userService;
            this.frontDescriptionTypeService = frontDescriptionTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                return this.View();
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(FrontDescriptionTypeViewModel frontDescriptionTypeViewModel)
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                await this.frontDescriptionTypeService.AddFrondDescriptionTypeAsync(frontDescriptionTypeViewModel);
                return this.RedirectToAction("Index","Home");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();
                bool isFrontDescriptionTypeExist = await this.frontDescriptionTypeService.isExistByIdAsync(Id);

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }
                if (!isFrontDescriptionTypeExist)
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
                FrontDescriptionTypeViewModel frontDescriptionTypeViewModel = await this.frontDescriptionTypeService.GetByIdAsync(Id);
                return this.View(frontDescriptionTypeViewModel);

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(FrontDescriptionTypeViewModel frontDescriptionTypeViewModel)
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();
                bool isFrontDescriptionTypeExist = await this.frontDescriptionTypeService.isExistByIdAsync(frontDescriptionTypeViewModel.Id);

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }
                if (!isFrontDescriptionTypeExist)
                {
                    return this.ErrorIfTaskDontExist();
                }
                if(!ModelState.IsValid)
                {
                    return this.View(frontDescriptionTypeViewModel);
                }

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                await this.frontDescriptionTypeService.EditFrontDescriptionTypeAsync(frontDescriptionTypeViewModel);
                return this.RedirectToAction("Index", "Home");
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
        private IActionResult ErrorIfTaskDontExist()
        {
            this.TempData[ErrorMessage] = ErrorIfFrontTaskDontExistMessage;

            return RedirectToAction("Index", "Home");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return RedirectToAction("Index", "Home");
        }
    }
}
