namespace CodingExcercise_SplitArrayValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] webNames = { "abc.edu", "pqr.com", "imno.org" };

            string[] resultArray = RemoveDNSfromWEB(webNames);

            PrintResultArray(resultArray);
        }



        private static string[] RemoveDNSfromWEB(string[] webNames)
        {
            string webNamevalue;
            int webNameslength;
            string eachStringvalue;
            string[] outputArray = new string[webNames.Length]; //to store result array
            for (int i = 0; i < webNames.Length; i++)
            {
                webNamevalue = webNames[i];
                webNameslength = webNamevalue.Length;// finding length of each index value
                eachStringvalue = ExtractString(webNamevalue, webNameslength); // // to get string before "." character
                outputArray[i] = eachStringvalue;  // storing each index string result value
            }
            return outputArray;
        }

        private static string ExtractString(string webNamevalue, int webNameslength)
        {
            //functionality : to find string before "." character
            string currentStringValue = "";
            string outputArraystring = "";
            for (int i = 0; i < webNameslength; i++)
            {
                char currentcharvalue = webNamevalue.ToCharArray()[i];
                currentStringValue = currentcharvalue.ToString();
                if (currentStringValue == ".")
                {
                    break;
                }
                outputArraystring += currentStringValue;
            }
            return outputArraystring;

        }
        private static void PrintResultArray(string[] resultArray)
        {
            foreach (string s in resultArray)
            { Console.WriteLine(s); }
        }


    }
}


