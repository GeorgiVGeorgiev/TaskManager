using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class FrontDescriptionController : Controller
    {
        public async Task<IActionResult> Add()
        {
            return View();
        }
    }
}
