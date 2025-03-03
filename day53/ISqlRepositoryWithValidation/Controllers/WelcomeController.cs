using Microsoft.AspNetCore.Mvc;

namespace ISqlRepositoryWithValidation.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
