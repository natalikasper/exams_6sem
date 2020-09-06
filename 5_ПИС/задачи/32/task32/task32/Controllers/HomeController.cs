using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using task32.Models;
using task32.ViewModel;

namespace task32.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, task32.Data.AppContext context)
        {
            context.Phones.Add(new Data.DbModel.Phone());
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ValidationTesting()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidationTesting(PlanViewModel plan)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return View(plan);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
