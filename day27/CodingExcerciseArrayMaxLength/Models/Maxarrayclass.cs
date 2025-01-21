using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExcerciseArrayMaxLength.Models
{
    internal class Maxarrayclass
    {
        public static int MaxLength(string[] arr)
        {
            int biggestLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > biggestLength)
                {
                    biggestLength = arr[i].Length;
                }
            }
            return biggestLength;
        }

        public static int MaxValuecount(string[] arr, int biggestIndexlength)
        {
            int valueCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == biggestIndexlength)
                {
                    valueCount++;
                }
            }
            return valueCount;
        }

        public static string[] GenerateBiggestArray(int biggestIndexlength, int biggestindexNumberofvalue, string[] arr)
        {
            string[] outputArray = new string[biggestindexNumberofvalue];
            int outputArrayindex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == biggestIndexlength)
                {
                    outputArray[outputArrayindex] = arr[i];
                    outputArrayindex++;
                }
            }
            return outputArray;
        }

    }
}
