using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars vaz = new Model("Vaz 21011");
            Model b = vaz as Model;
            b.CoolOrNot(1977, 10000);
            b.maxspeed(160);
            Console.ReadLine();
        }
    }
}
