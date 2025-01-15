using System.Runtime.CompilerServices;

namespace NumberGuessGameWithoutOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameRule();
            UserChoice();
        }
        private static void UserChoice()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string UserInput = "";
            Console.WriteLine("Type Y to Play and N for quit Game.");
            UserInput = Console.ReadLine();

            UserInput = UserInput.ToUpper();
            if (UserInput == "Y")
            {
                GenerateRandomNumber();

            }
            if (UserInput == "N")
            {

                Console.WriteLine("Thanks For Visiting. Good bye.");
                Console.ForegroundColor = ConsoleColor.White;
                System.Environment.Exit(0);
            }
            Console.WriteLine("Enter a Correct input.");
            UserChoice();

        }

        private static void GenerateRandomNumber()
        {

            int MinNumber = 1;
            int MaxNumber = 50;
            Random RandomNumber = new Random();
            int WinningNumber = RandomNumber.Next(MinNumber, MaxNumber);
            StartGame(WinningNumber);
        }

        private static void StartGame(int winningNumber)
        {
            int MagicNumber = winningNumber;
            int MaxAttempt = 3;
            int UserInput;
            for (int i = 0; i < MaxAttempt; i++)
            {
                Console.WriteLine($"Guess attempt : {i + 1}");
                UserInput = int.Parse(Console.ReadLine());
                if (UserInput == MagicNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Congratulation you won!! Winning Number is {MagicNumber}");
                    UserChoice();
                }
                if (i == MaxAttempt - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Sorry Winning Number is : {winningNumber} , Better Luck Next Time.");
                    UserChoice();

                }
                if (UserInput != MagicNumber)
                {
                    if (UserInput < MagicNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Magic Number is greater than your Number.");
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Magic Number is less than your Number.");
                    continue;

                }

            }

        }

        private static void GameRule()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Number Guessing Game. Please note the rules of game below :");
            Console.WriteLine("Game Rule 1: You have only 3 attempt to guess the number.");
            Console.WriteLine("Game Rule 2: Winning Number is from range 1 to 50.");
            Console.WriteLine("Good Luck!!");
        }
    }
}
