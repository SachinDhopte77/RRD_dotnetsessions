using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGameWithOOP.Models
{
    internal class GameBluePrint
    {

        private string _UserInput;
        private int _MinNumber = 1;
        private int _MaxNumber = 50;
        private int _Attempt;
        private int _MaxAttempt = 10;
        private int _MinAttempt = 3;
        private int _ResultValue;

        public void GameRule()
        {
            //Rule
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Number Guessing Game. Please note the rules of game below :");
            Console.WriteLine("Game Rule 1: You can select number of guess attempt you like? range is from 3 to 10");
            Console.WriteLine("Game Rule 2: Winning Number is from range 1 to 50.");
            Console.WriteLine("If you fill like a pro. Reduce Number of Guess Attempt");
            Console.WriteLine("Good Luck!!");
        }

        public void Exit()
        {
            Console.WriteLine("Thanks for Visiting. Have a nice day");
            Environment.Exit(0);
        }


        public string Start(int UserAttempt, int MagicNumber)
        {
            string result = "Y";
            for (int i = 1; i <= UserAttempt; i++)
            {
                Console.WriteLine($"Guess Attempt : {i}");
                int UserEnteredValue = int.Parse(Console.ReadLine());
                if (UserEnteredValue == MagicNumber)
                {
                    Console.WriteLine($"Congratulations You Won!! Magic Number is {MagicNumber}");
                    result = "Y";
                    break;

                }
                if (i == UserAttempt)
                {
                    Console.WriteLine($"Better Luck Next Time. Magic number was  {MagicNumber} ");

                }
                if (UserEnteredValue < MagicNumber)
                {
                    Console.WriteLine("Entered Number is Less Than Magic Number.");
                }
                else Console.WriteLine("Entered Number is greater Than Magic Number.");

            }
            return result;
        }

        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(_MinNumber, _MaxNumber);

        }

        public string UserInput
        {
            get { return _UserInput; }
            set { _UserInput = UserValue(value); }
        }
        private string UserValue(string value)
        {
            value = value.ToUpper();
            if (value == "Y") { return value; }
            if (value == "N") { return value; }
            return "I";
        }
        public int MaxAttempt
        {
            get { return _Attempt; }
            set { _Attempt = SetupMaxAttempt(value); }
        }

        private int SetupMaxAttempt(int value)
        {
            if (value < _MinAttempt) { return _MinAttempt; }
            if (value > _MaxAttempt) { return _MaxAttempt; }
            return value;
        }


    }
}
