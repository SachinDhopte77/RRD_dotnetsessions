using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attrubute_Custume.Models
{
    internal class DeactiveClass2
    {
        [Deactivated]
        public void DeactivateMethod1() { Console.WriteLine("DeactiveClass2->Deactivated Method1"); }

        [Active]
        public void PrintMethod() { Console.WriteLine("DeactiveClass2->PrintMethod"); }

    }
}
