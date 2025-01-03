namespace ConsoleApp_Hello_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int Hello_Counter = 10;
            int Hello_Running_Counter = 0;
            while (Hello_Running_Counter < Hello_Counter)
            { 
                Hello_Running_Counter++;
                Console.WriteLine(Hello_Running_Counter.ToString() + " Hello, World!");
            }
        }
    }
}
