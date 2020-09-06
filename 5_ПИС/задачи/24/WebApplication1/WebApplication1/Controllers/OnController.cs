using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplication1.Controllers
{
    public class OnController : Controller
    {
        private string Txt = "";
        public override void OnActionExecuting(ActionExecutingContext context)  //до акции
        {
            Console.WriteLine(this.Txt += "- OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext context)    //после акции
        {
            Console.WriteLine(this.Txt += "- OnActionExecuted");
        }

        //on/a1
        public IActionResult A1()
        {
            Console.WriteLine(this.Txt += "-A1");
            return Content("Action:A1");
        }

        //on/a2
        public IActionResult A2()
        {
            Console.WriteLine(this.Txt += "-A2");
            return Content("Action: A2");
        }
    }
}