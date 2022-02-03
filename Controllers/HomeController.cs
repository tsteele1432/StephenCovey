using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Tasks()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }
    }
}
