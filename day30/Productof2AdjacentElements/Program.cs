namespace Productof2AdjacentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] InputArray = { 5, 2, 5, 7, 3 };

            FindtwoAdjacentElement(InputArray);
        }

        private static void FindtwoAdjacentElement(int[] InputArray)
        {
            int currentArrayvalue = 0;
            int nextArrayvalue = 0;
            int diffrenceResult = 0;
            int[] resultArray = new int[InputArray.Length - 1];
            for (int i = 0; i < InputArray.Length; i++)
            {
                if (i == 0) { currentArrayvalue = InputArray[i]; }

                else if (i < InputArray.Length)
                {
                    nextArrayvalue = InputArray[i];
                    diffrenceResult = nextArrayvalue - currentArrayvalue;
                    resultArray[i - 1] = Math.Abs(diffrenceResult);
                    currentArrayvalue = nextArrayvalue;
                }
            }
            TwoLowestAdjacentElement(resultArray, InputArray);

        }

        private static void TwoLowestAdjacentElement(int[] resultArray, int[] InputArray)
        {
            int lowestresultarrayValue = 0;
            int lowestresultarrayIndex = 0;
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i == 0) { lowestresultarrayValue = resultArray[i]; }
                else if (lowestresultarrayValue > resultArray[i])
                {
                    lowestresultarrayValue = resultArray[i];
                    lowestresultarrayIndex = i;
                }
            }
            PrintTwoLowestAdjacentElement(lowestresultarrayIndex, InputArray);
        }

        private static void PrintTwoLowestAdjacentElement(int lowestresultarrayIndex, int[] inputArray)
        {
            Console.WriteLine($"two adjacent value is :{inputArray[lowestresultarrayIndex]} and {inputArray[lowestresultarrayIndex + 1]} ");
            Console.WriteLine($"Result of multiplication of two adjacent value is :{inputArray[lowestresultarrayIndex] * inputArray[lowestresultarrayIndex + 1]}");
        }
    }
}
