using CodingExcerciseArrayBorder.Models;

namespace CodingExcerciseArrayBorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Sachin", "Venkat", "Akhilesh", "Minu", "Prem" };

            DiplayArrayBorder(Border.AddBorderToArray(arr));

        }

        private static void DiplayArrayBorder(string[] outputArray)
        {
            foreach (string str in outputArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
