using ObjectArrayPolymorphism.Models;

namespace ObjectArrayPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] array = { 1, 2, 3, 8, 9, 15 };
            int sumofArray = MathFunction.SumMethod(array);
            int averageofArray = MathFunction.AverageMethod(array);

            PrintSum(sumofArray);
            PrintAvg(averageofArray);
        }

        private static void PrintAvg(int averageofArray)
        {
            Console.WriteLine("Average of Object Array value: " + averageofArray);
        }

        private static void PrintSum(int sumofArray)
        {
            Console.WriteLine("Sum of Object Array value: " + sumofArray);
        }
    }
}
