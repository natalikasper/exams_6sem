using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using ASP3MVC.Models;
using Newtonsoft.Json;

namespace ASP7.Controllers
{
    public class TSController : ApiController
    {
        DictObjectContext context = new DictObjectContext();

        // GET: api/TS
        public IEnumerable<DictObject> Get()
        {
            return context.GetAll().OrderBy(i => i.Surname);
        }

        // POST: api/TS
        public void Post([FromBody]DictObject value)
        {
            value.Id = context.GetAll().Last().Id+1;
            context.Add(value);
        }
    }
}

/*
 * TSController – реализует ф-нал web api
* он образован от класса ApiController  (не связан с Controller) 
* все методы с именем метода HTTP (иначе надо указ в виде атрибута [HttpPost])
* примен. стиль REST – для взаимод. с сервером в rest-арх исп. методы HTTP (get, post, put, delete) – тут нет обчных методов д-й как в традиц. контроллерах, кот. возвращаются ActionResult

 */
