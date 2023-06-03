using Microsoft.AspNetCore.Mvc;

namespace DotNet6Identity.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
