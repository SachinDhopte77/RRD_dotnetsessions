class Program
{
    static void Main()
    {
        string[] RRDfolks = GetvaluesinArray(); //Initialising Array

        PrintNameForwardLoop(RRDfolks);//Redirecting to function: Returning Value in forward loop

        PrintNameBackwardLoop(RRDfolks);//Redirecting to function: Returning Value in Backword loop
    }
    static string[] GetvaluesinArray()
    {
        string[] rrdfolks = { "Sachin", "Venkat", "Akhilesh" };
        return rrdfolks;

    }
    static void PrintNameForwardLoop(string[] rrdfolks)
    {
        for (int i = 0; i < rrdfolks.Length; i++)
        {
            Console.WriteLine($"Hellow rrdfolks " + $"{rrdfolks[i]}");
        }
    }
    static void PrintNameBackwardLoop(string[] rrdfolks)
    {
        for (int i = rrdfolks.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Hellow rrdfolks " + $"{rrdfolks[i]}");
        }
    }
}
