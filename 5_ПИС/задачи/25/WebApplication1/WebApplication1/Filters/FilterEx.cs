using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 Фильтры исключений обрабатывают необработанные исключения, в том числе те, 
 которые возникли при создании контроллера и привязки модели.
 */



namespace WebApplication1.Filters
{
    public class FilterEx : Attribute, IExceptionFilter
    {
        //ExceptionContext - получить сведения об исключ.
        public void OnException(ExceptionContext context)
        {
            string actionName = context.ActionDescriptor.DisplayName;
            string exceptionStack = context.Exception.StackTrace;
            string exceptionMessage = context.Exception.Message;
            context.Result = new ContentResult
            {
                Content = $"В методе {actionName} возникло исключение: \n {exceptionMessage} \n {exceptionStack}"
            };
            context.ExceptionHandled = true;    //чтобы исключение считалось обработанным
        }
    }
}
