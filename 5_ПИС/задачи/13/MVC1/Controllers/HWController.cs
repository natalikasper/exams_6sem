using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    [RoutePrefix("it")]
    public class HWController : Controller
    {
        // GET: /it/23/catdog2

        [HttpGet]
        [Route("{n:int}/{str}")]
        public void A(int n, string str)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"GET: A:/{n}/{str}");
            result.AppendLine($"{n} - целое число; {str} - строка");

            Response.Write(result.ToString());
        }

        // GET, POST: /it/true/house
        [AcceptVerbs("get", "post")]
        [Route("{b:bool}/{letters:alpha}")]
        public void M02(bool b, string letters)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{Request.HttpMethod}:B:/{b}/{letters}");
            result.AppendLine($"{b} - boolean; {letters} - строка из букв;");

            Response.Write(result.ToString());
        }



        // GET: HW
        public ActionResult Index()
        {
            return View();
        }
    }
}
/*
 [Route("{b:bool}/{letters:alpha}")]
 [Route("{f:float}/{str:length(2,5)}")]
 [Route(@"{letters:regex(^[a-zA-Z]{3,4}$)}/{n:range(100, 200)}")]
*/
