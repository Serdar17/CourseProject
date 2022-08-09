using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return RedirectToAction("Index", "Home");
            //return View();
        }
    }
}
