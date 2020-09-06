using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;      //пр-во имен моделей

namespace MVC1.Controllers
{
    public class HWController : Controller
    {
        // Модель представления (строго-типизир предст)
        public class A
        {
            int x = 0, y = 0;
            public A(int x, int y) { this.x = x; this.y = y; }
            public int Sum { get { return this.x + this.y; } }
        }
        
        public ActionResult M()
        {
            return View(new A(3, 5));
        }

        //---------------------------------------------
        // Модель данных

        List<Company> companies = new List<Company>
        {
            new Company { Id = 1, Name = "Apple", Country = "США" },
            new Company { Id = 2, Name = "Samsung", Country = "Республика Корея" },
            new Company { Id = 3, Name = "Google", Country = "США" }
        };



        public ActionResult Index()
        {
            ViewBag.Objects = companies;
            return View();
        }
    }
}