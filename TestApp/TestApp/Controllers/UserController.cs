using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using TestApp.Model;

namespace TestApp.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        [Route("login")]
        [HttpGet]
        public IActionResult Login(string redirectUrl = null)
        {
            ViewData["redirectUrl"] = redirectUrl;
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(User user, string redirectUrl)  //powinno sie tu spr czy user istnieje na bazie
        {
            if (ModelState.IsValid)
            {
                var claims = new List<Claim>
                {
                    new Claim("password", user.Password)
                };

                var cookieProperty = new ClaimsIdentity(claims, "Cookie");
                var properties = new ClaimsPrincipal(cookieProperty);
                await HttpContext.SignInAsync(properties);
                return RedirectPermanent(redirectUrl);
            }
            return View();
        }
    }
}