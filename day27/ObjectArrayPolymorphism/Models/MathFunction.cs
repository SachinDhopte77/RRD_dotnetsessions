using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArrayPolymorphism.Models
{
    internal class MathFunction : Average
    {
        public static int SumMethod(object[] objects)
        {
            int sum = 0;
            for (int i = 0; i < objects.Length; i++)
            {
                int j = (int)objects[i];
                sum = sum + j;
            }
            return sum;
        }
    }
}
