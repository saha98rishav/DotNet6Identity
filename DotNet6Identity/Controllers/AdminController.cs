﻿using Microsoft.AspNetCore.Mvc;

namespace DotNet6Identity.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
