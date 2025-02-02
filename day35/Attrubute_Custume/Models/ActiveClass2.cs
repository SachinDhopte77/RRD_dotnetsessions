using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrubute_Custume.Models
{
    internal class ActiveClass2
    {
        [Active]
        public void Method1()
        {
            Console.WriteLine("TestClass2 -> Method1");
        }

    }
}
