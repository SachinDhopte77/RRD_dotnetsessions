using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArray.Models
{
    public class CutumeArray<T>
    {
        public static T[] Flatten<T>(T[,,] arr)
        {
            int rows0 = arr.GetLength(0);
            int rows1 = arr.GetLength(1);
            int rows2 = arr.GetLength(2);
            T[] arrFlattened = new T[rows0 * rows1 * rows2];

            int i, j, k;
            for (k = 0; k < rows0; k++)
            {
                for (j = 0; j < rows1; j++)
                {
                    for (i = 0; i < rows2; i++)
                    {
                        var test = arr[k, j, i];
                        int index = i + j * rows2 + k * rows1 * rows2;
                        arrFlattened[index] = test;
                    }
                }
            }
            return arrFlattened;
        }
    }
}
