using System;
using GuessMyNumber;


namespace Extends
{
    class Extension : GuessingGame
    {
        public void endGame(string msg, int val)
        {

            if (val > 3)
            {
                Console.WriteLine($"{msg}, you lose!");
                foreach (int w in whatWrong)
                {
                    Console.Write($"{w} ");
                }
                Console.Write(".");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You got {val} wrong! You win!");
                Console.Write($"The numbers you guessed were ");
                foreach (int w in whatWrong)
                {
                    Console.Write($"{w} ");
                }
                Console.Write(".");
                Console.WriteLine();
            }
            whatWrong.Clear();
        }
    }
}
