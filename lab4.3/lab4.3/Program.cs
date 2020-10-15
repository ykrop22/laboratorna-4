using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A("zx", "cxs");
            B b = new B("t", "r", 34);
            b.Calc(3);
            Debug.WriteLine(b.num2);
            Debug.WriteLine(b.num1);
            Console.Read();
        }
    }
}
