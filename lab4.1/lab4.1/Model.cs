using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace lab4._1
{
    class Model : Cars
    {
        public Model(string Name) : base(Name)
        {
            __name = Name;
        }
        public void maxspeed(int maxSpeed)
        {
            Debug.WriteLine(maxSpeed.GetType());
            if (maxSpeed < 200)
            {
                Console.WriteLine("It is class B");
            }

            else
            {
                Console.WriteLine("What model?\n I don`t know");
            }
        }

    }
}