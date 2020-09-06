using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [Route("")] //по умолчанию
        public IActionResult Default()
        {
            return Content("Application:Home/Default");
        }

        [Route("Home/Index")]
        [Route("Index")]
        [Route("H/I")]
        public IActionResult Index()
        {
            logger.LogInformation("Information: Index");
            //return Content("Application:Home/Index");
            return View();
        }

        [Route("Home/One")]
        [Route("One")]
        [Route("H/O")]
        public IActionResult One()
        {
            logger.LogInformation("Information: One");
            //return Content("Application:Home/One");
            return View();
        }

        [Route("Home/Two")]
        [Route("Two")]
        [Route("H/T")]
        public IActionResult Two()
        {
            logger.LogInformation("Information: Two");
            //return Content("Application:Home/Two");
            return View();
        }

        [Route("{x:int}/{t:maxlength(3)}")]
        public IActionResult Parm(int x, string t)
        {
            return Content(String.Format("x = {0}, t = {1}", x, t));
        }

        [Route("square/{k:int}")]
        public IActionResult Square(int k)
        {
            ViewBag.Result = k * k;
            return View();
        }

        [Route("{n:minlength(1):maxlength(10)}/{y:int:min(1):max(150)}")]
        public IActionResult YearsOld(string n, int y)
        {
            return Content($"Your name is {n}, you're {y} years old");
        }

        [Route("Home/About")]
        [Route("About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [Route("Home/Contact")]
        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("Home/Privacy")]
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
