using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BaseInternational.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace BaseInternational.Controllers {
    public class HomeController : Controller {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController (IStringLocalizer<HomeController> localizer) {
            _localizer = localizer;
        }

        public IActionResult Index () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"]; 

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["Message"] = "Your contact page.";
            ViewData["YourName"] = _localizer["YourName"]; 
            ViewData["YourPhone"] = _localizer["YourPhone"]; 
            ViewData["YourEmail"] = _localizer["YourEmail"]; 
            ViewData["YourMessage"] = _localizer["YourMessage"]; 
            ViewData["Send"] = _localizer["Send"]; 

            return View ();
        }

        public IActionResult History () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["History"] = _localizer["History"]; 
            ViewData["HistoryText"] = _localizer["HistoryText"]; 

            return View ();
        }

        public IActionResult MineralWater () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["MineralWaterText2"] = _localizer["MineralWaterText2"]; 
            ViewData["MineralWaterYouGet"] = _localizer["MineralWaterYouGet"]; 
            ViewData["MineralWaterNoText"] = _localizer["MineralWaterNoText"]; 
            ViewData["Strawberry"] = _localizer["Strawberry"]; 
            ViewData["Raspberry"] = _localizer["Raspberry"]; 
            ViewData["Peach"] = _localizer["Peach"]; 
            ViewData["Orange"] = _localizer["Orange"]; 
            ViewData["LemonLime"] = _localizer["LemonLime"]; 
            ViewData["Blueberry"] = _localizer["Blueberry"];

            ViewData["MineralWater"] = _localizer["MineralWater"];

            return View ();
        }

        public IActionResult Team () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["CreativeDirector"] = _localizer["CreativeDirector"]; 
            ViewData["DirectorMarketing"] = _localizer["DirectorMarketing"]; 
            ViewData["DirectorProdDev"] = _localizer["DirectorProdDev"]; 
            ViewData["DirectorSales"] = _localizer["DirectorSales"]; 
            ViewData["HenryTwillBio"] = _localizer["HenryTwillBio"]; 
            ViewData["AngelaHashtonBio"] = _localizer["AngelaHashtonBio"]; 
            ViewData["JessicaNewtonSmithBio"] = _localizer["JessicaNewtonSmithBio"]; 
            ViewData["MariaSontasBio"] = _localizer["MariaSontasBio"]; 
            ViewData["MichaelLewistonBio"] = _localizer["MichaelLewistonBio"]; 
            ViewData["PhiTangBio"] = _localizer["PhiTangBio"];

            ViewData["Team"] = _localizer["Team"]; 
            

            return View ();
        }

        public IActionResult Philosophy () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["Philosophy"] = _localizer["Philosophy"];
            ViewData["PhilosophyText"] = _localizer["PhilosophyText"];


            return View ();
        }

        public IActionResult ActiveWearWomen () {
            ViewData["Home"] = _localizer["Home"]; 
            ViewData["Company"] = _localizer["Company"]; 
            ViewData["Philosophy"] = _localizer["Philosophy"]; 
            ViewData["History"] = _localizer["History"]; 
            ViewData["Team"] = _localizer["Team"]; 
            ViewData["Products"] = _localizer["Products"]; 
            ViewData["MineralWater"] = _localizer["MineralWater"]; 
            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"]; 
            ViewData["Contact"] = _localizer["Contact"]; 
            ViewData["Footer"] = _localizer["Discloser"]; 
            ViewData["Register"] = _localizer["Register"]; 
            ViewData["LogIn"] = _localizer["LogIn"];

            ViewData["TrainingTank"] = _localizer["TrainingTank"]; 
            ViewData["TrainingTankDescript"] = _localizer["TrainingTankDescript"]; 
            ViewData["Jeans"] = _localizer["Jeans"]; 
            ViewData["JeansDescript"] = _localizer["JeansDescript"]; 
            ViewData["Jacket"] = _localizer["Jacket"]; 
            ViewData["JacketDescript"] = _localizer["JacketDescript"]; 
            ViewData["DancePants"] = _localizer["DancePants"]; 
            ViewData["DancePantsDescript"] = _localizer["DancePantsDescript"]; 
            ViewData["TankTop"] = _localizer["TankTop"]; 
            ViewData["TankTopDescript"] = _localizer["TankTopDescript"]; 
            ViewData["Vest"] = _localizer["Vest"]; 
            ViewData["VestDescript"] = _localizer["VestDescript"];

            ViewData["ActiveWearWomen"] = _localizer["ActiveWearWomen"];

            return View ();
        }

        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)  
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}