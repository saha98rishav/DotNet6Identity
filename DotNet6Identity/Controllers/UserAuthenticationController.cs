using Microsoft.AspNetCore.Mvc;

namespace DotNet6Identity.Controllers
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
