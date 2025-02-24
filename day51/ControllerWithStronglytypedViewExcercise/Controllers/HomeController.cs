using Microsoft.AspNetCore.Mvc;

namespace ControllerWithStronglytypedViewExcercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
