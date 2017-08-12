using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BaseInternational.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace BaseInternational.Controllers {
    public class HomeController : Controller {
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController (IStringLocalizer<HomeController> localizer) {
            _localizer = localizer;
        }

        public IActionResult Index () {
            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";
            ViewData["YourName"] = _localizer["YourName"]; 
            ViewData["YourPhone"] = _localizer["YourPhone"]; 
            ViewData["YourEmail"] = _localizer["YourEmail"]; 
            ViewData["YourMessage"] = _localizer["YourMessage"]; 
            ViewData["Send"] = _localizer["Send"]; 

            return View ();
        }

        public IActionResult History () {
            ViewData["Message"] = "Your history page.";

            return View ();
        }

        public IActionResult MineralWater () {
            ViewData["Message"] = "Your water page.";

            return View ();
        }

        public IActionResult Team () {
            ViewData["Message"] = "Your team page.";

            return View ();
        }

        public IActionResult Philosophy () {
            ViewData["Message"] = "Your Philosophy page.";

            return View ();
        }

        public IActionResult ActiveWearWomen () {
            ViewData["Message"] = "Your Active Wear - Women page.";

            return View ();
        }

        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}