using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Covey.Models;

namespace Covey.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ILogger<HomeController> logger)
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tasks()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tasks(Task task)
        {
            return View("Confirmation", task);
        }

        public IActionResult Quadrants()
        {
            return View();
        }
    }
}
