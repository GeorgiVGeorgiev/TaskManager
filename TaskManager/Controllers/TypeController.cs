namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;
    using TaskManager.Web.ViewModels.Type;
    using static Common.NotificationMessages;
    using static Common.ErrorMessageBulgarian;

    [Authorize(Roles ="Administrator")]
    public class TypeController : Controller
    {
        private readonly IAdminService adminService;
        private readonly IUserService userService;
        private readonly ITypeService typeService;

        public TypeController(IAdminService adminService, IUserService userService, ITypeService typeService)
        {
            this.adminService = adminService;
            this.userService = userService;
            this.typeService = typeService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<TypeViewModel> typeViewModel = await this.typeService.GetAllTypesAsync();

            return View(typeViewModel);
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
        public async Task<IActionResult> Add(TypeViewModel typeViewModel)
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }
                if (!ModelState.IsValid)
                {
                    return this.View(typeViewModel);
                }

            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                await this.typeService.AddTypeAsync(typeViewModel);
                return this.RedirectToAction("All", "Type");
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
                bool isTypeExist = await this.typeService.IsExistByIdAsync(Id);

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }
                if(!isTypeExist)
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
                TypeViewModel typeViewModel = await this.typeService.GetByIdAsync(Id);

                return this.View(typeViewModel);
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TypeViewModel typeViewModel)
        {
            try
            {
                bool isUserAdmin = this.User.isAdmin();
                bool isTypeExist = await this.typeService.IsExistByIdAsync(typeViewModel.Id);

                if (!isUserAdmin)
                {
                    return this.ErrorIfUserIsNotAdmin();
                }
                if (!isTypeExist)
                {
                    return this.ErrorIfTaskDontExist();
                }
                if(!ModelState.IsValid)
                {
                    return this.View(typeViewModel);
                }
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
            try
            {
                await this.typeService.EditTypeAsync(typeViewModel);
                return this.RedirectToAction("All", "Type");
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
            this.TempData[ErrorMessage] = ErrorIfTypeDontExistMessage;

            return RedirectToAction("Index", "Home");
        }

        private IActionResult GeneralError()
        {
            this.TempData[ErrorMessage] = GeneralErrorMessage;

            return RedirectToAction("Index", "Home");
        }
    }
}
