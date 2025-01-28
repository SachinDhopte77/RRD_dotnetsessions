using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise.Models
{
    internal class Man : IMannarable
    {
        public void Depart()
        {
            Console.WriteLine("Interface : IMannarable || Class : Man -> Inside the Depart Method");
        }

        public void Wish()
        {
            Console.WriteLine("Interface : IMannarable || Class : Man -> Inside the Wish Method");
        }
    }
}
