﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HWController : Controller
    {
        // GET: HW
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}