using Microsoft.AspNetCore.Mvc;

namespace DotNet6Identity.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
