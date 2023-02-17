using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class NumberGame
    {
        private Random random = new Random();
        private int userNumber;
        private int currRandomNumber;
        private int amtGuesses = 0;

        public void Begin()
        {
            bool playAgain = false;

            DisplayMenu();

            do
            {
                amtGuesses = 0;
                currRandomNumber = GetRandomNumber();
                AskPlayerUntilCorrect();
                GameOver();
                playAgain = DoYouWantToPlayAgain();

            } while (playAgain);
        }
        
        private void DisplayMenu()
        {
            Console.WriteLine("------------------ GUESS THE NUMBER ------------------");
            Console.WriteLine("  The computer will choose a number between 0 and 99");
            Console.WriteLine("  You need to guess the right number. The game will");
            Console.WriteLine("  let you know whether your guess is correct,");
            Console.WriteLine("  greater than or less than the random number.");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
        }

        private int GetRandomNumber()
        {
            int randNum = random.Next(0, 100);

            return randNum;
        }

        private void AskPlayerUntilCorrect()
        {
            bool isCorrectGuess = false;

            while (!isCorrectGuess)
            {
                ReadNumber();

                if (userNumber == currRandomNumber) 
                {
                    isCorrectGuess = true;
                }
                else
                {
                    if (userNumber > currRandomNumber)
                    {
                        Console.WriteLine("Your guess is too high!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too low!");
                        Console.WriteLine();
                    }
                }

                amtGuesses++;
            }
        }

        private void ReadNumber()
        {
            while (true)
            {
                Console.Write("Guess a number between 0 and 99: ");

                string str = Console.ReadLine();

                if (int.TryParse(str, out userNumber))
                {
                    if (userNumber >= 0 && userNumber < 100)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Number must be between 0 and 99!\n");
                    }
                }
                else
                {
                    Console.WriteLine("Must be a number!\n");
                }
                
            }
        }

        private void GameOver()
        {
            Console.WriteLine();
            Console.WriteLine("Congratulations, you guessed the right number after " + amtGuesses + " guess(es)!");
        }

        private bool DoYouWantToPlayAgain()
        {
            bool answer = false;
            bool done = true;

            Console.Write("Do you want to play again? (y/n); ");

            do
            {
                string str = Console.ReadLine();
                str = str.ToUpper();

                if (str[0] == 'Y')
                {
                    answer = true;
                }
                else if (str[0] == 'N')
                {
                    answer = false;
                }
                else
                {
                    Console.WriteLine("Please use y/n!");
                    done = false;
                }
            }
            while (!done);
            Console.WriteLine();

            return answer;
        }
    }
}
