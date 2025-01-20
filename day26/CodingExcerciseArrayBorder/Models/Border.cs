using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcerciseArrayBorder.Models
{
    internal class Border
    {
        public static string[] AddBorderToArray(string[] arr)
        {
            int NumberofInputArrayValues = arr.Length;
            int j = NumberofInputArrayValues + 2;
            int add = 0;
            string[] outputArray = new string[j];
            for (int i = 0; i <= NumberofInputArrayValues - 1; i++)
            {
                if (i == 0)
                {
                    outputArray[add] = "#####";
                    add++;
                    outputArray[add] = "#" + arr[i] + "#";
                }
                else if (i == NumberofInputArrayValues - 1)
                {
                    add++;
                    outputArray[add] = "#" + arr[i] + "#";
                    add++;
                    outputArray[add] = "#####";
                }
                else
                {
                    add++;
                    outputArray[add] = "#" + arr[i] + "#";
                }
            }
            return outputArray;
        }
    }
}
