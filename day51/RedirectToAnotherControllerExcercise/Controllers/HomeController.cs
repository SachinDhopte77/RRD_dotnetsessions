using Microsoft.AspNetCore.Mvc;

namespace RedirectToAnotherControllerExcercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index","Customer");
            //return View();
        }
    }
}
