using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise.Models
{
    internal class Boy : IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Interface : IEmotionable || Class : Boy -> Inside the Cry Method");
        }

        public void Laugh()
        {
            Console.WriteLine("Interface : IEmotionable || Class : Boy -> Inside the Laugh Method");
        }
    }
}
