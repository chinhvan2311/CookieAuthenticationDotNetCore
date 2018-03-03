using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CookieAuthenticationDotNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            string userName = HttpContext.User.Identity.Name;

            if (HttpContext.User.IsInRole("Administrator"))
            {
                ViewData["adminMessage"] = "You are an Administrator!";
            }

            if (HttpContext.User.IsInRole("Manager"))
            {
                ViewData["managerMessage"] = "You are a Manager!";
            }

            ViewData["username"] = userName;

            return View();
        }
    }
}