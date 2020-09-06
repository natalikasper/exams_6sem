using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

/*
 Фильтры действий (Action Filters) реализуют либо интерфейс IActionFilter, 
 либо интерфейс IAsyncActionFilter. Фильтры действий выполняются после 
 фильтров авторизации и ресурсов и уже после того, как произошла привязка модели. 
 Поэтому данные фильтры являются прекрасным местом для исследования результатов 
 привязки модели, а также модификации входных данных в метод контроллера или его 
 результата
     */

namespace WebApplication1.Filters
{
    /*
     В данном случае у нас определен фильтр пробелов, который удаляет пробелы из 
     выходного кода html. Основная работа перенесена во вспомогательный класс 
     SpaceCleaner. А ключевыми здесь являются методы OnActionExecuting() и 
     OnActionExecuted().
         */
    public class FilterD : Attribute, IActionFilter
    {
        /*
        Метод OnActionExecuting() вызывается до выполнения метода контроллера.
        В качестве параметра он принимает контекст выполнения -
        объект ActionExecutingContext, который имеет ряд свойств.
        Посредством изменения значения ActionExecutingContext.ActionArguments можно 
        манипулировать параметрами метода. Либо через значение 
        ActionExecutingContext.Controller можно управлять контроллером.
Кроме того, метод OnActionExecuting() может завершить обработку запроса путем
установки свойства ActionExecutingContext.Result.
    */

        private string Txt = "";
        public void OnActionExecuting(ActionExecutingContext context)  //до акции
        {
            Console.WriteLine(" A1 -  OnActionExecuting");
        }


        /*
         Метод OnActionExecuted() вызывается после выполнения метода и получает в
         качестве параметра объект ActionExecutedContext. На этом этапе мы можем увидеть
         результат выполнения и как-то его изменить через свойство 
         ActionExecutedContext.Result.
                     */

        public void OnActionExecuted(ActionExecutedContext context)    //после акции
        {
            Console.WriteLine(" A1 - OnActionExecuted");
        }

    }
}
