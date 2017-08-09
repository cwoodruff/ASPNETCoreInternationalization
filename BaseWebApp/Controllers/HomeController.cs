using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BaseInternational.Models;

namespace BaseInternational.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Your history page.";

            return View();
        }

        public IActionResult MineralWater()
        {
            ViewData["Message"] = "Your water page.";

            return View();
        }

        public IActionResult Team()
        {
            ViewData["Message"] = "Your team page.";

            return View();
        }

        public IActionResult Philosophy()
        {
            ViewData["Message"] = "Your Philosophy page.";

            return View();
        }

        public IActionResult ActiveWearWomen()
        {
            ViewData["Message"] = "Your Active Wear - Women page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
