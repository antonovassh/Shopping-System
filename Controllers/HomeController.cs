using Microsoft.AspNetCore.Mvc;

namespace Sprint16_EntityFrameworkCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/index.cshtml");
        }
    }
}
