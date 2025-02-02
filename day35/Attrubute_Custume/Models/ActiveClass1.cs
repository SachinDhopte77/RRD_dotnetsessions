using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrubute_Custume.Models
{
    internal class ActiveClass1
    {
        [Active]
        public void Method1()
        {
            Console.WriteLine("TestClass1->Method1");
        }
        [Active]
        public void Method2()
        {
            Console.WriteLine("TestClass1->Method2");
        }

        [Deactivated]
        public void Method3() { Console.WriteLine("TestClass1->Method3"); }

    }
}
