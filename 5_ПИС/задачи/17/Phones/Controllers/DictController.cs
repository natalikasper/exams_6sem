using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ninject;
using Ninject.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Phones.Controllers
{
    public class DictController : Controller
    {
        DI.IA ia = null;
        public DictController(DI.IA ia)
        {
            this.ia = ia;
        }

        public ActionResult M01()
        {
            //не глобальная регистрация
            //IKernel kernel = new StandartKernel(new DI.NIConfig());
            //DI.IA a1 = kernel.Get<DI.IA>();

            int r1 = ia.add(3, 4);
            int r2 = ia.sub(3, 4);

            return Content($"<h1>r1 = {r1}, r2 = {r2}</h1>");
        }
    }
}