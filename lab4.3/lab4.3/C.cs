﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    class C:A
    {
        private int __char = '-';
        public int Char2 { get; private set; }
        public int Char3 { private get; set; }
        public C(char c, char c1, string p1, string p2) : base(p1, p2)
        {
            Char2 = c;
            Char3 = c1;
        }
        public void Calc(int n)
        {
            Console.WriteLine(__char + Char2 + Char3);
        }
    }
}
