using CodingExcerciseArrayMaxLength.Models;

namespace CodingExcerciseArrayMaxLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Venkat", "Minu", "Sachin" };

            int biggestIndexlength = Maxarrayclass.MaxLength(arr);

            int biggestindexNumberofvalue = Maxarrayclass.MaxValuecount(arr, biggestIndexlength);

            string[] outputArray = Maxarrayclass.GenerateBiggestArray(biggestIndexlength, biggestindexNumberofvalue, arr);

            PrintDetail(outputArray);

        }

        private static void PrintDetail(string[] outputArray)
        {
            foreach (var item in outputArray)
                Console.WriteLine(item);
        }
    }
}
