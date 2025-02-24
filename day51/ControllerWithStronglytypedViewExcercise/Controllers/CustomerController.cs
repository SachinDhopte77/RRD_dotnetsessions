using ControllerWithStronglytypedViewExcercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerWithStronglytypedViewExcercise.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerDetails()
        {
            CustomerAddressInfo customerAddressInfo = new CustomerAddressInfo
            {
                Id = 1,
                Name = "Sachin",
                Email = "sachin@gmail.com",
                Phone = "9999999",
                Addresses=new List<CutomerAddress>
                {
                    new CutomerAddress{Address1="Dombivali",Address2="Thane",Pincode="100010",ID=1},
                    new CutomerAddress{Address1="TRP Nachane",Address2="Ratnagiri",Pincode="400705",ID=2}
                }
           
            };             
            return View(customerAddressInfo);
        }
    }
}
