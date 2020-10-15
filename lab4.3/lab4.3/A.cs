using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    class A
    {
        public string firstName { get; private set; }
        public string secondName { get; set; }
        public A(string s1, string s2)
        {
            firstName = s1;
            secondName = s2;
        }
    }
}
