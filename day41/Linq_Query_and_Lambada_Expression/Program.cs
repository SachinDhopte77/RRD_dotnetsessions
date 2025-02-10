namespace LINQArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Sachin", "Sanjay", "Venkat", "Akhilesh" };

            Console.WriteLine("Filter using LinQ query");

            var startwithSusingLinQ = (from str in strings where str.StartsWith("S") select str );//Using LinQ

            foreach ( var str in startwithSusingLinQ )
            {
                Console.WriteLine( str );
            }

            Console.WriteLine("Filter using Lambada Expression");
            var startwithSusingLambada=strings.Where(x => x.StartsWith("S")); ////Using Lambada

            foreach(var str in startwithSusingLambada)
            { Console.WriteLine( str ); }
        }
    }
}
