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
        private string Txt = "";
        //применение фильтра действия
        [Filters.FilterD]
        //применение фильтра ресурсов
        [Filters.FilterR]
        //применение фильтра результата
        [Filters.FilterRes] //проверяем в заголовках время
        //польховательский фильтр
        [Filters.FilterU]
        public IActionResult A1()
        {
            Console.WriteLine(this.Txt += "-A1");
            return Content("Action:A1");
        }

        [Filters.FilterEx]
        public IActionResult About()
        {
            int x = 0;
            int y = 8 / x;
            return View();
        }

        [Filters.FilterRP]
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
