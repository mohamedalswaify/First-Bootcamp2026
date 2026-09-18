using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bootcamp_MVC_EF.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult LoginConfirm(string email , string password)
        {
            if(email=="m@gmail.com" && password=="12345")
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }




        }
}
