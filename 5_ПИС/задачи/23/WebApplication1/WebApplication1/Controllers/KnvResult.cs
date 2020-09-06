using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//собственный класс, который реализ. IActionResult
//сами создаем класс, в котором можем реализовать действия о генерации вывода
namespace WebApplication1.Controllers
{
    public class KnvResult : IActionResult
    {
        string html = "<html>\n"
                                + "<head> \n"
                                + "<title> KnvResult </title>\n"
                                + "<meta charset=utf-8 /> \n"
                                + "</head> \n"
                                + "<body> \n"
                                + "<h1> {0} </h1> \n"
                                + "</body> \n"
                                + "</html> \n";
        string txt;
        public KnvResult(string txt)
        {
            this.txt = txt;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            //запускаем нашу html
            await context.HttpContext.Response.WriteAsync(string.Format(html, txt));
        } 

    }
}
