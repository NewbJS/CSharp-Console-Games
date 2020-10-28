using System;
using GuessMyNumber;
using NameCode;

namespace Home
{

    class Home
    {

        private static GuessingGame g = new GuessingGame();
        private static Name n = new Name();

        public static void Main(string[] args)
        {

            Console.WriteLine("What game would you like to play? Type 'Guess' for a guessing game, and 'Name' for a name game!");
            string toPlay = Console.ReadLine();

            if (toPlay == "Guess")
            {
                g.Game();
            }
            else if (toPlay == "Name")
            {
                n.NameGame();
            }
            else
            {
                Console.WriteLine("That is not a game!");
            }
        }

    }
}