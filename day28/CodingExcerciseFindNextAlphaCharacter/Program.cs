namespace CodingExcerciseFindNextAlphaCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string[] strings = { "abcd", "pqrs" };

            PrintArrayValue(strings);

            string[] outputString = FindNextAlphabetString(strings, Alphabet);

            PrintArrayValue(outputString);
        }


        private static string[] FindNextAlphabetString(string[] strings, char[] alphabet)
        {
            string nextChar;
            string[] outputArray = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                string stringvalue = strings[i];
                int stringLength = stringvalue.Length;
                string newString = "";
                for (int j = 0; j < stringLength; j++)
                {
                    char extractCurrentcharvalue = stringvalue.ToCharArray()[j];
                    nextChar = LoopThroughNextAlphacharacter(extractCurrentcharvalue, alphabet);
                    newString = newString.Insert(j, nextChar);
                }
                outputArray[i] = newString;
            }
            return outputArray;
        }

        private static string LoopThroughNextAlphacharacter(char extractedValuefromstring, char[] alphabet)
        {
            string result = "";
            for (int i = 0; i < alphabet.Length; i++)
            {

                if (extractedValuefromstring == 'z')
                {
                    result = extractedValuefromstring.ToString();
                    break;
                }
                else if (alphabet[i] == extractedValuefromstring)
                {
                    result = alphabet[i + 1].ToString();
                    break;
                }

            }
            return result;
        }

        private static void PrintArrayValue(string[] strings)
        {
            foreach (var value in strings)
            {
                Console.WriteLine(value);
            }
        }



    }
}


