using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrubute_Custume.Models
{
    internal class DeactiveClass1
    {
        [Deactivated]
        public void DeactivateMethod1() { Console.WriteLine("DeactiveClass1-> Deactivated Method1"); }

        [Active]
        public void Method2()
        {
            Console.WriteLine("Deactivated Class1-> Method2");
        }

    }
}
