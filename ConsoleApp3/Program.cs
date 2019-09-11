using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new demoEntities();

            var demo = new demo1()
            {
                id = 1,
                name = "DEMO1",
                description = "Demo 1 descriptcion"
            };

            context.demo1.Add(demo);
            context.SaveChanges();

        }
    }
}
