namespace HelloWord_CommandLineArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            { 
            Console.WriteLine(args[i].ToUpper() + " Welcome to C#");
            }
            Console.WriteLine();

            for (int i = args.Length-1; i >= 0; i--)
            {
                Console.WriteLine(args[i].ToUpper() + " Welcome to C#");
            }

        

        }
    }
}
