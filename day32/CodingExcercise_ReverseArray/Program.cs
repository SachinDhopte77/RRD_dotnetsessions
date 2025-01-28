namespace CodingExcercise_ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "abc", "pqr", "xyz" };

            int startIndex = 0; int endIndex = array.Length - 1;

            ArrayElementinReverseOrder(array, startIndex, endIndex);

            Console.WriteLine("Array In reverse order ->");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ArrayElementinReverseOrder(string[] array, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                string tempStratIndex = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = tempStratIndex;
                startIndex++;
                endIndex--;
            }
        }
    }
}
