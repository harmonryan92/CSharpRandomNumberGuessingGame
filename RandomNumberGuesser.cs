using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClass
{
    class RandomNumberGuesser
    {
        private static void numberGuesser()
        {
            do
            {
                Random randNum = new Random();
                int hidden = randNum.Next(100);
                int guess;
                int guessCount = 0;
                bool correct = false;

                Console.WriteLine("Guess what number between 1 and 100 I'm thinking of: ");
                while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1)
                {
                    Console.WriteLine("Invalid input. Enter a number between 1 and 100.");
                }

                while (!correct)
                {
                    if (guess > hidden)
                    {
                        Console.WriteLine("The number {0} is too high! Guess again.", guess);
                        while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1)
                        {
                            Console.WriteLine("Invalid input. Enter a number between 1 and 100.");
                        }
                        guessCount++;
                    }
                    else if (guess < hidden)
                    {
                        Console.WriteLine("The number {0} is too low! Guess again.", guess);
                        while (!int.TryParse(Console.ReadLine(), out guess) || guess < 1)
                        {
                            Console.WriteLine("Invalid input. Enter a number between 1 and 100.");
                        }
                        guessCount++;
                    }
                    else
                    {
                        guessCount++;
                        correct = true;
                        Console.WriteLine("You got it! {0} was the number. It took you {1} guesses. Type Y to play again or hit any key to exit.", guess, guessCount);
                    }
                }
            } while (Console.ReadLine() == "Y");
        }
        static void Main(string[] args)
        {
            numberGuesser();
        }
    }
}
