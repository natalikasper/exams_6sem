using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace WebApplication1.Controllers
{
    
    public class VDemoController : Controller
    {
        //абстр.класс, т.к.не реализ.абстр.метод ExecuteAsync
        //его реализ.представл

        //в качестве щаблона - класс TM, а также здесь указ.тип модели
        //который мы будем использовать в качестве view - указ.в директиве модели 
        //(передаем, когда вызываем view)
        public abstract class VDemo<TM> : RazorPage<TM>
        {
            //свойства
            public string description { get; set; } = "Description";
            public DateTime date { get; set; } = DateTime.Now;
        }

        //вызываем 2 view, которые сделаны с сп-нием баз.класса
        
        //VDemo/Twelve
        public IActionResult Twelve()
        {
            return View("Twelve", "xxxx");
        }

        //VDemo/Thirteen
        public IActionResult Thirteen()
        {
            return View("Thirteen", DateTime.Now);
        }
    }
}
