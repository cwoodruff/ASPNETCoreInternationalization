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

            return View ();
        }

        public IActionResult History () {

            return View ();
        }

        public IActionResult MineralWater () {

            return View ();
        }

        public IActionResult Team () {            

            return View ();
        }

        public IActionResult Philosophy () {

            return View ();
        }

        public IActionResult ActiveWearWomen () {

            return View ();
        }

        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}