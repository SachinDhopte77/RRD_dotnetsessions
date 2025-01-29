namespace CodingExcecise_RotateArrayClockwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40 };

            int startIndex = 0; int endIndex = array.Length - 1;

            ArrayElementinClockwiseOrder(array, startIndex, endIndex);

            Console.WriteLine("Array In Clockwise order ->");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ArrayElementinClockwiseOrder(int[] array, int startIndex, int endIndex)
        {
            int tempStartIndex = array[startIndex];//Assigning first index value to temp variable
            int nextIndex = 0; //to check next index value
            while (startIndex < endIndex)
            {
                nextIndex++; //incrementing to read next index value
                array[startIndex] = array[nextIndex]; //assigning next index value to current index
                if (startIndex == endIndex - 1) { startIndex++; array[startIndex] = tempStartIndex; continue; } //if start index value reach to second last index of the array Assign first index value stored in temp variable to last index of the array
                startIndex++; // incrementing current index value

            }
        }
    }
}
