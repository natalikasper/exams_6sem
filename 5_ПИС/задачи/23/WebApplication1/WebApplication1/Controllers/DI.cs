using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//внедрение зависимостей
namespace WebApplication1.Controllers
{
    public class CDI
    {
        private string txt = "Empty";

        public CDI()
        {
            Console.WriteLine("CDI: construtor");
        }

        public string Set(string s)
        {
            Console.WriteLine(this.txt = s);
            return this.txt;
        }

        public string Get()
        {
            Console.Write(this.txt);
            return this.txt;
        }
    }
}
