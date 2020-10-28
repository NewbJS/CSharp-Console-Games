using System;
using GameInterface;
using System.Collections.Generic;
using Extends;

namespace GuessMyNumber
{

    class GuessingGame : IGame
    {

        public static List<int> whatWrong = new List<int>();

        public void Game()
        {
            Random rand = new Random();
            Console.WriteLine("Guess a random number from 0 to 10!");
            int ranNum = rand.Next(11);


            do
            {
                int a;
                string guessStr = Console.ReadLine();
                if (!int.TryParse(guessStr, out a))
                {
                    Console.WriteLine("Not an integer!");
                }
                else
                {
                    int guess = Convert.ToInt32(guessStr);
                    if (guess > ranNum)
                    {
                        Console.WriteLine("Guess lower!");
                        whatWrong.Add(guess);
                    }
                    else if (guess < ranNum)
                    {
                        Console.WriteLine("Guess higher!");
                        whatWrong.Add(guess);
                    }
                    else
                    {
                        Console.WriteLine("You guessed correctly!");

                        Extension e = new Extension();

                        e.endGame(
                            $"You lost, you got {whatWrong.Count} correct",
                            whatWrong.Count
                        );

                        Console.WriteLine("Do You want to play again? [y/n]");
                        string read = Console.ReadLine();
                        string response = read.Substring(0, 1).ToLower();
                        if (response == "y")
                        {
                            Game();
                        }
                        else
                        {
                            Console.WriteLine("Exited.");
                        }
                        break;
                    }
                }
            } while (true);
        }
    }
}
