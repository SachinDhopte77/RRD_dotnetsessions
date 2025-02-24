using Microsoft.AspNetCore.Mvc;
using ViewBagExcercise.Models;

namespace ViewBagExcercise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult UserName(string userName="Sachin")
        {
            UserMaster userMaster = new UserMaster();
            AppUser appUser = userMaster.GetUser(userName);
            ViewBag.AppUser = appUser;
            ViewBag.Header = "User Detail";
            return View();
        }
    }
}
