using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Local.Models;
using System.Globalization;

namespace Local.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var currentCultureName = CultureInfo.CurrentCulture.EnglishName;
            var currentUICultureName = CultureInfo.CurrentUICulture.EnglishName;

            ViewData["Message"] = "Your application description page.";

            ViewData["Content"] = "<p><table border=\"1\" cellpadding=\"5\" style=\"border-collapse:collapse;\">"
                + $"<tr><td>Current Culture</td><td>{currentCultureName}</td></tr>"
                + $"<tr><td>Current UI Culture</td><td>{currentUICultureName}</td></tr>"
                + $"<tr><td>The Current Date</td><td>{DateTime.Now.ToString("D")}</td></tr>"
                + $"<tr><td>A Formatted Number</td><td>{(1234567.89).ToString("n")}</td></tr>"
                + $"<tr><td>A Currency Value</td><td>{(42).ToString("C")}</td></tr>"
                + "</table></p>";   

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
