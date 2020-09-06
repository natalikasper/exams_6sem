using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
 Фильтры результатов (Result Filters) начинают выполняться после всех остальных фильтров. 
 Они реализуют либо интерфейс IResultFilter, либо интерфейс IAsyncResultFilter. 
 Фильтры результатов вып.только тогда, когда вып-ние метода завершилось успешно. 
  */

/*
 Фильтры результатов не вызываются, если фильтры исключений обрабатывают исключение, 
 но не устанавливают свойство Exception = null.
  */

/*
 фильтры результатов применяются, когда надо выполнить какую-то постобработку результата 
 метода, отформатировать его.
 */

namespace WebApplication1.Filters
{
    //фильтр, кот получает время вып-ния рез-та д-вий
    public class FilterRes : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("DateTime", DateTime.Now.ToString());
            Console.WriteLine(" A1 -  OnResultExecuting");
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine(" A1 -  OnAResultExecuted");
        }
    }
}
