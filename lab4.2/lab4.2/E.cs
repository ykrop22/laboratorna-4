using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class E : B
    {
        public int keysOnMouse = 2;
        public override void NewLVL(int n1)
        {
            __lvl += keysOnMouse;
        }
    }
}

