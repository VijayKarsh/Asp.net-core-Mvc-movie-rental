using Microsoft.AspNetCore.Mvc;
using Super_Movie_Store.Models.ViewModel;

namespace Super_Movie_Store.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Signup()
        {
            return View();
        }

        //Post
        [HttpPost]
        public IActionResult Signup(LoginSignupViewModel model)
        {
            return View();
        }


        //GET
       

    }
}
