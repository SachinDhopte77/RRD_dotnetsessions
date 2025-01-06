class Program
{
    static void Main()
    {
        string[] RRDNameArray = { "Sachin", "Akhilesh", "Venkat", "Minu" };//initialising array

        Console.WriteLine("Using Join Statement :");

        LoopUsingJoin(RRDNameArray); //using Join statement function

        Console.WriteLine("Using ToList For Each :");

        ToListForEach(RRDNameArray); //Using ToList For Each

        Console.WriteLine("Using Recursion function");//using Recusrsion Function

        int RRDNameArraysize = RRDNameArray.Length - 1;

        RecursiveFunction(RRDNameArraysize, RRDNameArray);

    }
    static void LoopUsingJoin(string[] RRDNameArray)
    {
        Console.WriteLine(string.Join(Environment.NewLine, RRDNameArray));
    }

    static void ToListForEach(string[] RRDNameArray)
    {
        RRDNameArray.ToList().ForEach(x => Console.WriteLine(x));
    }

    static int RecursiveFunction(int arraysize, string[] RRDNameArray)
    {
        if (arraysize >= 0)
        {
            Console.WriteLine(RRDNameArray[arraysize]);
            RecursiveFunction(arraysize - 1, RRDNameArray);
        }
        return 1;
    }

}
