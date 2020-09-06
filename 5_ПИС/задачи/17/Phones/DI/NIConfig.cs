
using Ninject.Modules;
using Ninject.Web.Common;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phones.DI
{
    public interface IA
    {
        int sub(int x, int y);
        int add(int x, int y);
    }
    public class A1 : IA
    {
        public int add(int x, int y) { return x + y; }
        public int sub(int x, int y) { return x - y; }
    }


    public class A2 : IA
    {
        public int add(int x, int y) { return x *y; }
        public int sub(int x, int y) { return x *y; }
    }

    public class NIConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IA>().To<A1>(); // TASK 1 - новый экземпляр на каждый вызов
            //Bind<IA>().To<A2>();
            //Bind<IPhoneDictionary<Contact>>().To<PhoneDictionary>().InThreadScope();  //TASK 2 - новый экземпляр на каждый поток

            //Bind<IPhoneDictionary<Contact>>().To<PhoneDictionary>().InRequestScope(); //TASK 3 - новый экземпляр на каждый HTTP-запрос
        }
    }
}