using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class prints a multiplication table of 12 * 12 and also calculates
    /// the sum, even numbers, odd numbers and square roots between the two numbers
    /// chosen by the user
    /// </summary>
    internal class MathWork
    {
        public void Start()
        {
            PrintMultiplicationTable(); // Prints the multiplication table once
            Calculate(); // Calls the calculate method
        }

        private void PrintMultiplicationTable()
        {
            Console.WriteLine("MULTIPLICATION TABLE:");

            // The for loop continues and makes a table print until it reaches 12 * 12
            for (int row = 1; row <= 12; row++)
            {
                for (int col = 1; col <= 12; col++)
                {
                    Console.Write("{0,-5}", row * col);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        private void Calculate()
        {
            int firstNum = 0; // Local variable for the first number that the user chooses
            int secondNum = 0; // Local variable for the decond number that the user chooses
            bool done = false; // done = false so that the while loop can start and continue until done = true

            while (!done)
            {
                Console.WriteLine("Sum numbers between any two numbers!");

                firstNum = GetFirstNumber(firstNum); // Getting the first number from the user
                secondNum = GetSecondNumber(secondNum); // Getting the second number from the user

                // Swapping the first and second number if the second number is bigger than the first number
                if (firstNum > secondNum)
                {
                    int tempNum = secondNum;

                    secondNum = firstNum;
                    firstNum = tempNum;
                }

                SumNumbers(firstNum, secondNum); // Calculates the sum of all the numbers between the first and second number chosen by the user and prints them
                PrintEvenNumbers(firstNum, secondNum); // Calculates the even numbers between the numbers chosen by the user and prints them
                PrintOddNumbers(firstNum, secondNum); // Calculates the odd numbers between the numbers chosen by the user and prints them
                CalculateSquareRoots(firstNum, secondNum); // Calculates the square roots between the numbers chosen by the user and prints them

                done = ExitCalculation(); // done = true and exits the loop if the user chooses to exit math work
            }
        }

        private void SumNumbers(int startNum, int endNum)
        {
            int sum = 0;
            for (int s = startNum; s <= endNum; s++)
            {
                sum = sum + s;
            }

            Console.WriteLine();
            Console.WriteLine("The sum between " + startNum + " and " + endNum + " is: " + sum + "\n");
        }

        private int GetFirstNumber(int number1)
        {
            // Getting the first number from the user
            // If not given a number it gives an error and loops again
            while (true)
            {
                Console.Write("Give first number: ");
                string str1 = Console.ReadLine();

                if (int.TryParse(str1, out number1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Must be a number!\n");
                }
            }
            return number1;
        }

        private int GetSecondNumber(int number2)
        {
            // Getting the second number from the user
            // If not given a number it gives an error and loops again
            while (true)
            {
                Console.Write("Give second number: ");
                string str2 = Console.ReadLine();

                if (int.TryParse(str2, out number2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Must be a number!\n");
                }
            }
            return number2;
        }

        private void PrintEvenNumbers(int number1, int number2)
        {
            Console.WriteLine("EVEN NUMBERS:");

            // Calculates the even numbers between the numbers chosen by the user and
            // prints them with spaces in between
            for (int f = number1; f <= number2; f++)
            {
                if (f % 2 == 0)
                {
                    Console.Write("{0,-5}", f);
                }
            }
            Console.WriteLine("\n");
        }

        private void PrintOddNumbers(int number1, int number2)
        {
            Console.WriteLine("ODD NUMBERS:");

            // Calculates the odd numbers between the numbers chosen by the user and
            // prints them with spaces in between
            for (int f = number1; f <= number2; f++)
            {
                if (f % 2 != 0)
                {
                    Console.Write("{0,-5}", f);
                }
            }
            Console.WriteLine("\n");
        }

        private void CalculateSquareRoots(int number1, int number2)
        {
            Console.WriteLine("SQUARE ROOTS:");

            // Calculates the square roots between the numbers chosen by the user and
            // also prints them in a triangular format
            for (int f = number1; f <= number2; f++)
            {
                Console.Write("Sqrt({0,3} to{1,3})", f, number2);
                for (int r = f; r <= number2; r++)
                {
                    double root = Math.Sqrt(r);
                    Console.Write(string.Format("{0,6:f2}", root));
                }
                Console.WriteLine();
            }
        }

        private bool ExitCalculation()
        {
            bool answer = false;
            bool done = false;

            // Asks the user if they'd like to exit math work
            // The user must answer with something starting with either
            // y or n, othwerwise it prints an error message and loops again
            do
            {
                Console.Write("\nDo you want to exit math work? (y/n): ");

                string str = Console.ReadLine();
                str = str.ToUpper();

                if (str != "")
                {
                    if (str[0] == 'Y')
                    {
                        answer = true;
                        done = true;
                    }
                    else if (str[0] == 'N')
                    {
                        answer = false;
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Please use y/n!");
                    }
                }
                else
                {
                    Console.WriteLine("You didn't enter anything, please use y/n!");
                }
            }
            while (!done);

            return answer;
        }
    }
}
