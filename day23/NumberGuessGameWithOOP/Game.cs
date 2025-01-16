using NumberGuessGameWithOOP.Models;

namespace NumberGuessGameWithOOP
{
    internal class Game
    {
        static void Main(string[] args)
        {
            GameBluePrint Game = new GameBluePrint();
            Game.GameRule();// Game Rule
            GameSetup(Game);//Game Setup
        }
        private static void GameSetup(GameBluePrint Game)
        {
            int GuessAttempt = 0;
            string UserInput;
            Console.WriteLine("Press Y to play game and Press N to quit the game?");
            UserInput = Console.ReadLine();
            Game.UserInput = UserInput;
            if (Game.UserInput == "N" || Game.UserInput == "I") { GameDashboard(GuessAttempt, Game.UserInput, Game); }
            Console.WriteLine("Please Enter a Number of guess attempt you like? range is from 3 to 10");
            GuessAttempt = int.Parse(Console.ReadLine());
            Game.MaxAttempt = GuessAttempt;
            GameDashboard(Game.MaxAttempt, Game.UserInput, Game);

        }

        private static void GameDashboard(int UserAttempt, string? UserInput, GameBluePrint Game)
        {
            if (UserInput == "N")
            {
                Game.Exit();
            }
            if (UserInput == "I")
            {
                Console.WriteLine("Please enter a Correct Input.");
                GameSetup(Game);
            }
            if (UserInput == "Y")
            {
                int MagicNumber = Game.RandomNumber();
                Game.Start(UserAttempt, MagicNumber);
                GameSetup(Game);
            }
        }
    }
}
