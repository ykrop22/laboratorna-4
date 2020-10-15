using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            C b1 = new C();
            b1.NewLVL(12);
            Console.Read();
        }
    }
}
