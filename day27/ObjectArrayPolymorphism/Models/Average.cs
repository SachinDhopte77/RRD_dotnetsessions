using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArrayPolymorphism.Models
{
    internal class Average
    {
        public static int AverageMethod(object[] objects)
        {
            int divisial = objects.Length;
            int sum = 0;
            for (int i = 0; i < objects.Length; i++)
            {
                int j = (int)objects[i];
                sum = sum + j;
            }
            return sum / divisial;
        }
    }
}
