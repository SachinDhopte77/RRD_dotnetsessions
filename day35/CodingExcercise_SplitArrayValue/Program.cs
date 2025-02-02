




namespace CodingExcercise_SplitArrayValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] webNames = { "abc.edu", "pqr.com", "imno.org" };

            string[] resultArray= RemoveDNSfromWEB(webNames);

            PrintResultArray(resultArray);
        }

        private static void PrintResultArray(string[] resultArray)
        {
            foreach (string s in resultArray)
            {  Console.WriteLine(s); }
        }

        private static string[] RemoveDNSfromWEB(string[] webNames)
        {
            string webNamevalue;  
            int webNameslength;
            string eachStringvalue;
            string[] outputArray= new string[webNames.Length]; //to store result array
            for (int i = 0; i < webNames.Length; i++)
            {
                webNamevalue = webNames[i];
                webNameslength=webNamevalue.Length;// finding length of each index value
                int dotIndexposition=FindSepratorIndex(webNamevalue,webNameslength); // to get the position of "." character
                eachStringvalue=GenerateEachindexString(webNamevalue, dotIndexposition); // to get string before "." character
                outputArray[i]= eachStringvalue;  // storing each index string result value
            }
            return outputArray;
        }

        private static int  FindSepratorIndex(string webNamevalue, int webNameslength)
        {
            //functionality : to find index number of "." character
            int dotIndexposition = 0;
            for (int i = 0;i < webNameslength;i++)
            {
                char currentcharvalue=webNamevalue.ToCharArray()[i];
                string currentStringValue=currentcharvalue.ToString();
                if (currentStringValue == ".")
                { 
                    dotIndexposition = i;                    
                    break; 
                }

                 
            }
            return dotIndexposition;

        }

        private static string GenerateEachindexString(string webNamevalue, int dotIndexposition)
        {
            // Functionality : extract string before "." character
            string outputArraystring="";
            for (int i = 0; i < webNamevalue.Length; i++)
            {
                if (i < dotIndexposition)
                {
                    outputArraystring += webNamevalue[i].ToString();
                }
                else if (i == dotIndexposition) { break; }
            }
            return outputArraystring;
        }
    }
}
