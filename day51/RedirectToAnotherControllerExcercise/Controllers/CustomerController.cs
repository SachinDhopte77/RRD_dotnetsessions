using Microsoft.AspNetCore.Mvc;

namespace RedirectToAnotherControllerExcercise.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
