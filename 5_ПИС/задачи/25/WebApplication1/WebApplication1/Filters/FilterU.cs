using System;
using Microsoft.AspNetCore.Mvc.Filters;

//собственный пользовательский фильтр - простейший фильтр ресурсов
namespace WebApplication1.Filters
{
    public class FilterU : Attribute, IResourceFilter
    {
        //добавляет пользователю куки, кот хранит дату и время посл.визита
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            context.HttpContext.Response.Cookies.Append("LastVisit", DateTime.Now.ToString("dd/MM/yyyy hh-mm-ss"));
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // реализация отсутствует
        }
    }
}
