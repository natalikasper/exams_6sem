using System;
using System.Diagnostics;
using System.IO;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Routing;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //[ActionContext]     //внедрение контекста (если от контроллера не пришел контекс, можно внедрить)

        public HomeController()
        {
            //контекст контроллера
            ModelStateDictionary mst = this.ControllerContext.ModelState;   //валидация д-х
        }

        public IActionResult Index()
        {
            //контекст контроллера
            ControllerActionDescriptor cad = this.ControllerContext.ActionDescriptor;   //вызываемое действие
            RouteData rdt = this.ControllerContext.RouteData;   //данные маршрута

            //некоторые свойства контекста
            HttpContext hcx = this.ControllerContext.HttpContext;   //контекст запроса
            HttpRequest req = hcx.Request;  //запрос
            HttpResponse res = hcx.Response;    //ответ
            ISession ses = hcx.Session; //сессия
            ClaimsPrincipal clm = hcx.User; //инфа о пользователе
            
            return Content("Home/Index");
        }

        //собственный класс, который реализует IActionResult
        public IActionResult KnvAction()
        {
            //возвращаем объект, который реализует наш результат
            return new KnvResult("KnvActionResult");
        }


        //стандартные методы контроллера
        [ActionName("AEmpty")]      //имя акции - переименовывает стандартное имя
        public IActionResult AEmpty()
        {
            return new EmptyResult();       //пустой резалт, статус 200
        }

        public class A
        {
            public string X = "Hello";
        }
        [ActionName("AOK")]
        public IActionResult AOK()
        {
            //объект
            return Ok(new A());     //возвращает ObjectResult, status = 200; преобраз.в json
        }

        [ActionName("ABad")]
        public IActionResult ABad()
        {
            return BadRequest("ABad");      //возвращает DabRequestResult, status = 400
        }

        [ActionName("AUA")]
        public IActionResult AUa()
        {
            return Unauthorized();      //возвращает Unauth.Result; status = 401
        }

        [ActionName("ANF")]
        public IActionResult ANotFound()
        {
            return NotFound("NotFound");      //возвращает NotFoundResult; status = 404
        }

        [ActionName("ANC")]
        public IActionResult ANoContent()
        {
            return NoContent();      //возвращаетNoContenResult; status = 204
        }

        [ActionName("AST")]
        public IActionResult AStatucCode(int sc)
        {
            return StatusCode(sc == 0 ? 200 : sc);      //возвращает заданный код
        }

        [ActionName("ACR")]
        public IActionResult ACreated()
        {
            //уведомляет о создании нового ресурса, в заголовке Location - адрес нового ресурса
            return Created("http://localhost:5001/Home/ANC", new { name = "test" });      //status = 201
        }

        //вывод строки
        //https://localhost:5001/Home/AC?p1=xxx&p2=84
        [ActionName("AC")]
        public IActionResult AContent(string p1, int? p2)
        {
            //ContentResult - вывод строки
            return Content($"p1 = {p1}, p2 = {p2}");
        }

        //вывод json строки
        //https://localhost:5001/Home/AJ?p1=5&&p2=8
        [ActionName("AJ")]
        public IActionResult AJSON(string p1, int? p2)
        {
            //JsonResult - вывод json-строки
            return Json( new { x = p2, y=2, s=p1, d=DateTime.Now});
        }

        //отправка файлов
        //пишем строку и выбираем кодировку
        //конвертируем в поток байт
        //отправляем на строну клиента
        [ActionName("filebyte")]
        public IActionResult AFileContentResult()
        {
            string s = "111111111111111\nnatasha\nkasper\nexam\npis";
            System.Text.Encoding ec = new System.Text.UTF8Encoding();
            byte[] b = ec.GetBytes(s);
            return this.File(b, "application/text", "xxx.txt");
        }

        //скачать статический файл
        [ActionName("filevirt")]
        public IActionResult GetVirtualFile()
        {
            return File("~/Files/my1.docx", "application/mssword", "myX.docx");
        }

        //переадресация
        [ActionName("AR")]
        public IActionResult ARedirect(string p1, int? p2)
        {
            return Redirect($"http://localhost:5001/Home/AJ?p1={p1}&&p2={p2}");     //302
        }

        [ActionName("ARR")]
        public IActionResult APRedirect(string p1, int? p2)
        {
            return RedirectPermanent($"~/Home/AJ?p1={p1}&&p2={p2}");    //301
        }

        [ActionName("ARRR")]
        public IActionResult ALRedirect(string p1, int? p2)
        {
            //uri только локальный
            return LocalRedirect($"~/Home/AJ?p1={p1}&&p2={p2}");        //302
        }

        [ActionName("ARRRR")]
        public IActionResult ALPRedirect(string p1, int? p2)
        {
            //uri только локальный
            return LocalRedirectPermanent($"~/Home/AJ?p1={p1}&&p2={p2}");        //301
        }

        [ActionName("ARRRRR")]
        public IActionResult ARedirectToAction(string p1, int? p2)
        {
            return  RedirectToAction("AJ", "Home" , new { p1 = p1, p2 = p2 });        //302
        }

        [ActionName("ARRRRRR")]
        public IActionResult ARedirectToActionPermanent(string p1, int? p2)
        {
            return RedirectToActionPermanent("AJ", "Home", new { p1 = p1, p2 = p2 });        //301
        }

        [ActionName("ARRRRRRR")]
        public IActionResult ARedirectRoute(string p1, int? p2)
        {
            return RedirectToRoute("default",  new { controller = "Home", action = "AJ", p1=p1, p2=p2 });        //302
        }

        [ActionName("ARRRRRRRR")]
        public IActionResult ARedirectRoutePermanent(string p1, int? p2)
        {
            return RedirectToRoutePermanent("default", new { controller = "Home", action = "AJ", p1 = p1, p2 = p2 });       //302
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
