namespace ConsoleApp_HelloWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int hello_counter = 0;
            int hello_MsgCounter = 10;
            while (hello_counter < hello_MsgCounter)
            { 
                hello_counter++;
                Console.WriteLine( hello_counter.ToString() + ") Hello, World!");
            }
        }
    }
}
