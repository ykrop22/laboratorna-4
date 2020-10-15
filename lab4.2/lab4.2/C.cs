using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class C : B
    {
        public int skill = 0;
        public override void NewLVL(int n1)
        {
            __lvl += skill * n1;
        }
    }
}
