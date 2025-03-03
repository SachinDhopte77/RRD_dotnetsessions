using JQueryValidationRegistrationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace JQueryValidationRegistrationApp.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string email)
        {
            UserDataBase user = new UserDataBase();
            bool usercheck=user.isUserAvailable(name);
            if (usercheck) 
            {
                ViewBag.UserMessage = $"Welcome {name}";
            }
            else
            {
                ViewBag.UserMessage = $"User Not Found";
            }
            bool emailcheck = user.isEmailAvailable(email);
            if (emailcheck)
            {
                ViewBag.Message = $"Email found : {email}";
            }
            else
            {
                ViewBag.Message = $"Email Not found";
            }
            return View();
        }
    }
}
