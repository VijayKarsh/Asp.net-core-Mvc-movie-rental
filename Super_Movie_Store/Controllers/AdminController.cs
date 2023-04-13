using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Movie_Store.Models.ViewModel;
using System.Security.Claims;
using Super_Movie_Store.Models;

namespace Super_Movie_Store.Controllers
{
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AdminLogin()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AdminLogin(AdminViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var data = _context.Admin.Where(e => e.Username == model.Username).SingleOrDefault();
                if (data != null)
                {
                    bool isValid = (data.Username == model.Username && data.Password == model.Password);
                    if (isValid)
                    {
                        var identity1 = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.Username) },
                            CookieAuthenticationDefaults.AuthenticationScheme);

                        var principle = new ClaimsPrincipal(identity1);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                        HttpContext.Session.SetString("Username", model.Username);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["errorMessage"] = "Invalid Password";
                        return View(model);
                    }

                }
                else
                {
                    TempData["errorMessage"] = "Invalid Username";
                    return View(model);
                }
            }
            return View(model);

            
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("AdminLogin", "Admin");
        }

    }
}
