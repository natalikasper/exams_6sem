using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication1.Filters
{
    /*
     Фильтр ресурсов, как правило, применяется для переопределения результата действия.
     Это может быть полезно, например, в ситуации с кэшированием: в фильтре ресурсов
     можно получить кэш и сразу установить результат без ненужной повторной генерации
     результата в методах контроллера.

    Для создания фильтра ресурсов надо реализовать либо интерфейс IResourceFilter, 
    либо интерфейс IAsyncResourceFilter.
     */
    public class FilterR : Attribute, IResourceFilter
    {
        //фильтр для ограничения доступа к сайту старых браузеров типа IE
        //В качестве параметра в оба метода передается параметр типа ResourceExecutedContext, 
            //который позволяет получить данные запроса и управлять ответом.

        //срабатывает после выполнения метода и фильтров действий исключений и результатов
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine( " A1 - OnResourceExecuted");
        }

        //сраб.после фиотра авторизации, но до выполнения метода и работы фильтров д-вий, исключ и рез-тов
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine(" A1 - OnResourceExecuting");
        }
    }
}
