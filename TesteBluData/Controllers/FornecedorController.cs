﻿using Microsoft.AspNetCore.Mvc;

namespace TesteBluData.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
