using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ASP7
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}

/*
 App_Start/WebApiConfig – тут все определения маршрутов для web api 
 – тут определен один маршрут, в отличии  от обычных контроллеров 
 у нас здесь не действия, только конроллер. В завис от метода HTTP 
 прил. будет само различать к какому д-вию относится запрос
     */
