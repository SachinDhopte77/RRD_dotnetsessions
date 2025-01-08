using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter A Name :");
        string input = Console.ReadLine();
        bool match = false;
        CheckAlphabet(ref input, ref match);
    }

    static void CheckAlphabet(ref string? input, ref bool match)
    {
        match = Regex.IsMatch(input, "^[a-zA-Z]+$");
        if (match)
        {
            Console.WriteLine("Thank You!! Welcome to Training!!");
        }
        while (!match)
        {
            Console.WriteLine("Enter A Correct Name :");
            input = Console.ReadLine();
            CheckAlphabet(ref input, ref match);
        }


    }


}
