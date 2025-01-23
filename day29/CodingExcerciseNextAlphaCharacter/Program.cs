namespace CodingExcerciseNextAlphaCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string[] strings = { "acbd", "pqrs" };

            CheckAlphabetSequence(strings, Alphabet);

        }
        private static void CheckAlphabetSequence(string[] strings, char[] alphabet)
        {
            int nextCharintsequence;

            for (int i = 0; i < strings.Length; i++)
            {
                string stringvalue = strings[i];
                int stringLength = stringvalue.Length;
                int[] outputstingArray = new int[stringLength];
                for (int j = 0; j < stringLength; j++)
                {
                    char extractCurrentcharvalue = stringvalue.ToCharArray()[j];
                    nextCharintsequence = AlphabeticCharSequenceNumber(extractCurrentcharvalue, alphabet);
                    outputstingArray[j] = nextCharintsequence;
                }
                Console.WriteLine($"result of {i + 1} string is : " + ValidateString(outputstingArray));
            }

        }

        private static int AlphabeticCharSequenceNumber(char extractedValuefromstring, char[] alphabet)
        {
            int result = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == extractedValuefromstring)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        private static bool ValidateString(int[] outputstingArray)
        {
            bool result = true;
            for (int i = 0; i < outputstingArray.Length; i++)
            {
                if (i == 0) { continue; }
                else if (outputstingArray[i] < outputstingArray[i - 1])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
