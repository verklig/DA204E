using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class converts between celsius and fahrenheit 
    /// or fahrenheit and celsius depending on the users input
    /// </summary>
    internal class TempConverter
    {
        int userNum = 1; // The number chosen by the user

        public void Start()
        {
            PrintMenu(); // Prints the menu outside of the loop so that it only prints it once

            // While the number put in by the user is not = 0 it loops, otherwise it stops the loop
            while (userNum != 0)
            {
                userNum = ReadInput(); // Reads the user input and sets "userNum" as the number chosen by the user
                ChooseConverterAndCalculate(); // Depending on the user input, it converts the temperature accordingly
            }
        }
        
        private void PrintMenu()
        {
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("     TEMPERATURE CONVERTER\n");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine(" Celsius to Fahrenheit     : 1");
            Console.WriteLine(" Fahrenheit to Celsius     : 2");
            Console.WriteLine(" Exit                      : 0\n");
            Console.WriteLine("-------------------------------\n");
        }
        
        private int ReadInput()
        {
            bool done = false;

            // Changing the number put in by the user from a string into an integer, if that number is between 0 and 2
            // it stops the loop and continues, if not it displays an error message and loops again
            // If it doesn't succeed changeing whatever the user put in (for instance characters that are not numbers)
            // from a string into an integer it also displays an error message and loops again
            while (!done)
            {
                Console.Write("\n Your choice: ");
                string str = Console.ReadLine();

                if (int.TryParse(str, out userNum))
                {
                    if (userNum >= 0 && userNum <= 2)
                    {
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid input!");
                        done = false;
                    }
                }
                else
                {
                    Console.WriteLine(" Invalid input!");
                    done = false;
                }
            }
            return userNum; // Returns the "userNum" as an integer to be used by the next method
        }

        private void ChooseConverterAndCalculate()
        {
            // If the number chosen by the user is = 1, calculate celsius to fahrenheit
            // If the number chosen by the user is = 2, calculate fahrenheit to celsius
            // If the number chosen by the user is (in this case) = 0, quit the program
            // This quits the program because of that the while loop in the start method
            // is set to loop only if the number chosen by the user is not = 0
            if (userNum == 1)
            {
                CelsiusToFahrenheit(); 
            }
            else if (userNum == 2)
            {
                FahrenheitToCelsius();
            }
        }

        private void CelsiusToFahrenheit()
        {
            const int MAX = 100;

            Console.WriteLine();
            Console.WriteLine(" CELSIUS TO FAHRENHEIT:");

            // The for loop continues from 0 to the constant "MAX" set inside this method
            // It calculates and converts from celsius to fahrenheit and then
            // prints it out to the console after every loop
            for (double celsius = 0; celsius <= MAX; celsius += 4)
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine(" {0,6:f2} {1} {2}\t{3,6:f2} {4}", celsius, "C", "=", fahrenheit, "F");
            }
        }

        private void FahrenheitToCelsius()
        {
            const int MAX = 212;

            Console.WriteLine();
            Console.WriteLine(" FAHRENHEIT TO CELSIUS:");

            // The for loop continues from 0 to the constant "MAX" set inside this method
            // It calculates and converts from fahrenheit to celsius and then
            // prints it out to the console after every loop
            for (double fahrenheit = 0; fahrenheit <= MAX; fahrenheit += 10)
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine(" {0,6:f2} {1} {2}\t{3,6:f2} {4}", fahrenheit, "F", "=", celsius, "C");
            }
        }
    }
}