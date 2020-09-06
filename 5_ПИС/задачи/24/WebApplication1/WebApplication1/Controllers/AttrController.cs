using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class AttrController : Controller
    {
        //Attr/Index
        [HttpGet]
        public string Index()
        {
            string m = this.HttpContext.Request.Method;
            return $"Attr/Index: {m}";
        }

        //2/15
        [HttpGet("2/{x?}")]
        public string Two(int? x)
        {
            string m = this.HttpContext.Request.Method;
            return $"Attr/Index: {m} x = {x}";
        }

        //Home/One
        [HttpPost]
        public string One()
        {
            string m = this.HttpContext.Request.Method;
            return $"Attr/One: {m}";
        }

        //Attr/Three?x=4
        //для указания метода, при помощи которого необх.обработать запрос.
        [AcceptVerbs("GET")]        //любой метод
        public string Three(int? x)
        {
            string m = this.HttpContext.Request.Method;
            return $"Attr/Three: {m} x = {x}";
        }

        //передача параметров
        //Attr/Hello?id=9
        public string Hello(int id)
        {
            return $"id= {id}";
        }

        //несколько параметров
        //Attr/Square?a=10&h=3
        public string Square(int a, int h)
        {
            double s = a * h / 2;
            return $"Площадь треугольника с основанием {a} и высотой {h} равна {s}";
        }

        //по умолч
        public string Square2(int a = 3, int h = 10)
        {
            double s = a * h / 2;
            return $"Площадь треугольника с основанием {a} и высотой {h} равна {s}";
        }

        //передача массива
        //Attr/Sum?nums=1&nums=2&nums=3
        public string Sum(int[] nums)
        {
            return $"Сумма чисел равна {nums.Sum()}";
        }
    }
}