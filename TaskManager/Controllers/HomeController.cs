namespace TaskManager.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.FrontDescriptionType;

    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IFrontDescriptionTypeService frontDescriptionTypeService;

        public HomeController(IFrontDescriptionTypeService frontDescriptionTypeService)
        {
            this.frontDescriptionTypeService = frontDescriptionTypeService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<FrontDescriptionTypeViewModel> viewModel =await this.frontDescriptionTypeService.GetAllAsync();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int Id)
        {
             if (!await this.isExitByIdAsync(Id))
             {
               
                return  this.Error(500);
             }

             FrontDescriptionTypeViewModel viewModel = await this.frontDescriptionTypeService.GetByIdAsync(Id);

                return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404) 
            {
                return View("Error/Error404");
            }
            else if(statusCode == 500)
            {
                return View("Error/Error500");
            }
            return View("Error/Error");
        }

        private async Task<bool> isExitByIdAsync(int Id)
        {
             bool isExist = await this.frontDescriptionTypeService.isExistByIdAsync(Id);
             if (!isExist)
             {
                 return false;
             }
             return true;
        }
    }
}