﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class B
    {
        public string Nick = "HiDie";
        public int __lvl = 1;
        public B()
        {
            Console.WriteLine();

        }
        public virtual void NewLVL(int n1)
        {
            __lvl = n1;
        }
    }
}
