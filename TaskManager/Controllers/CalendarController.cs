using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace TaskManager.Controllers
{
    [Authorize(Roles = "Worker,Administrator")]
    public class CalendarController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
    }
}
