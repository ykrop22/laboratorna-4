using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace lab4._1
{
    class Cars
    {
        public string __name;
        public Cars(string Name = "null")
        {
            __name = Name;
        }
        public void CoolOrNot(int year, int price)
        {
            Debug.WriteLine(year);
            Debug.Write(price);
            if (price < 100000 & year < 2010)
            {

                Console.WriteLine($"{ __name} is  bad");

            }
            else
            {
                Console.WriteLine($"{__name}, nice car");
            }
        }

    }
}