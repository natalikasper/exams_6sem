using Microsoft.AspNetCore.Mvc;

namespace _28.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hello()
        {
            return Content("Hello word");
        }


    }
}
