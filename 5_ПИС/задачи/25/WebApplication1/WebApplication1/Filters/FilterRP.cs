using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 Фильтры Razor Pages срабатывают до и после того, как страница Razor Page обработает запрос.
   */

/*
 Фильтры Razor Pages срабатывают:
*Когда уже выбран метод Razor Page для обработки запроса, но до привязки модели.
*После завершения привязки данных, но до выполнения метода Razor Page, который обрабатывает запрос
*После завершения методом обработки запроса.
*/

namespace WebApplication1.Filters
{
    //запретить доступ юзерам с браузером IE
    public class FilterRP : Attribute, IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {

        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            // получаем информацию о браузере пользователя
            string userAgent = context.HttpContext.Request.Headers["User-Agent"].ToString();
            if (Regex.IsMatch(userAgent, "MSIE|Trident"))
            {
                context.Result = new BadRequestObjectResult("Ваш браузер устарел");
            }
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }
    }
}
