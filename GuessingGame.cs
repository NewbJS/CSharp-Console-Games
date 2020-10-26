using System;
using GameInterface;
using System.Collections;
using System.Collections.Generic;

namespace GuessMyNumber
{
    class GuessingGame : IGame
    {
        public static void Main(string[] args)
        {
            GuessingGame game = new GuessingGame();
            game.Game();
        }
        public void Game()
        {
            Random rand = new Random();
            Console.WriteLine("Guess a random number from 0 to 10!");
            int ranNum = rand.Next(11);
            List<int> whatWrong = new List<int>();

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
                        if (whatWrong.Count > 3)
                        {
                            Console.WriteLine($"You got {whatWrong.Count} wrong! You lose.");
                            Console.Write($"The numbers you guess were ");
                            for(int w = 0; w < whatWrong.Count; w++)
                            {
                                Console.Write($"{whatWrong[w]} ");
                            }
                            Console.Write(".");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"You got {whatWrong.Count} wrong! You win!");
                            Console.Write($"The numbers you guessed were ");
                            foreach(int w in whatWrong)
                            {
                                Console.Write($"{w} ");
                            }
                            Console.Write(".");
                            Console.WriteLine();
                        }
                        
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
