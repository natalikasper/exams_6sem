using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CDIController : Controller
    {
        private CDI di;

        public CDIController(CDI di)
        {
            this.di = di;
        }

        //https://localhost:5001/CDI/Index
        public IActionResult Index()
        {
            return Content("Index:" + di.Get());
        }

        ////https://localhost:5001/CDI/get
        public IActionResult Get()
        {
            return Content("Get:" + di.Get());
        }

        //https://localhost:5001/CDI/set?s=xxx
        public IActionResult Set(string s)
        {
            return Content("Set:" + di.Set(s));
        }
    }
}