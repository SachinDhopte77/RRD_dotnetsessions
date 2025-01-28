namespace CodingExcercise_SumOfAlternateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 10, 20, 30, 40, 50 };

            int[] ouputArray = SumofAlternateNumber(inputArray);

            PrintSumofAlternateNumber(ouputArray);
        }

        private static int[] SumofAlternateNumber(int[] inputArray)
        {
            int[] resultArray = new int[2];
            int sumofEvennumber = 0, sumofOddnumber = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumofEvennumber = sumofEvennumber + inputArray[i];
                    continue;
                }
                sumofOddnumber = sumofOddnumber + inputArray[i];

            }
            resultArray = [sumofEvennumber, sumofOddnumber];
            return resultArray;

        }

        private static void PrintSumofAlternateNumber(int[] SumofAlternateNumber)
        {
            for (int i = 0; i < SumofAlternateNumber.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Sum Of Even Number is: {SumofAlternateNumber[i]}");
                    continue;
                }
                Console.WriteLine($"Sum Of odd Number is: {SumofAlternateNumber[i]}");

            }
        }
    }
}
