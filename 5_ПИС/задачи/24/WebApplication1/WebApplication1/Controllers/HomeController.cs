using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult One()
        {
            return View();
        }

        //Area принимает отправляемые с формы данные
        //чтобы система могла связать пар-ры метода и д-е формы, необх., чтобы атрибуты name
        //у полей формы соотв.названиями пар-ров
        //Home/Index
        [HttpPost]
        public string Area(int altitude, int height)
        {
            double square = altitude * height / 2;
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

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
