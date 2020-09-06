using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //1. методы рендеринга
        //home/index
        public IActionResult Index()
        {
            return View();      //возвращает ViewResult
        }

        //2. 
        //Home/v1
        //передача д-х из контроллера в представление (2 способа)
        public IActionResult V1()
        {
            ViewData["Message"] = "ViewData. Передача данных в представление";
            ViewBag.Mess = "ViewBag. Передача данных в представление";
            return View("Any");
        }
        
        public class A
        {
            public int x = 0;
            public int y = 0;
            public int sum() { return x + y; }
        }

        //3.
        //home/v2
        public IActionResult V2()
        {
            return View(new A { x = 3, y = 2 });
        }

        //4.
        //home/v3
        public IActionResult V3()
        {
            return View("Any3", new A { x = 5, y = 4 });
        }

        //передача данных в представление
        public IActionResult V5()
        {
            List<string> City = new List<string>() { "Минск", "Брест", "Гомель", "Могилев", "Гродно", "Витебск" };
            return View("Any2", City);
        }

        //5.
        //home/v4
        public IActionResult V4()
        {
            return View("~/CSHTML/Out.cshtml");
        }

        //6.
        //home/if?view=v2
        //home/if
        public IActionResult If(string view)
        {
            ViewResult rc;
            if (view == null)
                rc = View("Index");
            else
                rc = View(view, new A { x = 3, y = 2 });
            return rc;
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
