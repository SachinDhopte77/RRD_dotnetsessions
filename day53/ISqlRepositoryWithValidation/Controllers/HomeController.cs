using ISqlRepositoryWithValidation.Data;
using ISqlRepositoryWithValidation.DTOs;
using ISqlRepositoryWithValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace ISqlRepositoryWithValidation.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AppUserDTO appUserDTO)
        {   
            if(ModelState.IsValid)
            {
                return View();
            }
            //var appuser=  _context.AppUser.SingleOrDefault(n=>n.UserName == appUserDTO.UserName);
           
            TempData["LoggedInUser"] = appUserDTO.UserName;
            return RedirectToAction("Index", "welcome");
            //var welcomeview = new WelcomeView
            //{
            //   UserName = appUserDTO.UserName,
            //   UserEmail=appUserDTO.Password,
            //   Password = appUserDTO.Password,
            //};
            //return View(welcomeview);
        }
    }
}
