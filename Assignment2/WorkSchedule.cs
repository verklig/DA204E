using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class prints the weekends or nights to work
    /// depending on the input given by the user
    /// </summary>
    internal class WorkSchedule
    {
        int userNum = 1; // The number chosen by the user

        public void Start()
        {
            PrintMenu(); // Prints the menu outside of the loop so that it only prints it once

            // While the number put in by the user is not = 0 it loops, otherwise it stops the loop
            while (userNum != 0)
            {
                userNum = ReadInput(); // Reads the user input and sets "userNum" as the number chosen by the user
                ChooseWeekendOrNightAndCalculate(); // Depending on the user input, it prints the weekends or nights to work
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("            YOUR WORK SCHEDULE           |");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine(" 1 : Show a list of the weekends to work.");
            Console.WriteLine(" 2 : Show a list of the nights to work.");
            Console.WriteLine(" 0 : Exit");
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("                                         |");
            Console.WriteLine("------------------------------------------\n");
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
                Console.Write(" Your choice: ");
                string str = Console.ReadLine();

                if (int.TryParse(str, out userNum))
                {
                    if (userNum >= 0 && userNum <= 2)
                    {
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid input!\n");
                        done = false;
                    }
                }
                else
                {
                    Console.WriteLine(" Invalid input!\n");
                    done = false;
                }
            }
            return userNum; // Returns the "userNum" as an integer to be used by the next method
        }

        private void ChooseWeekendOrNightAndCalculate()
        {
            // If the number chosen by the user is = 1, print weekends to work
            // If the number chosen by the user is = 2, print nights to work
            // If the number chosen by the user is (in this case) = 0, quit the program
            // This quits the program because of that the while loop in the start method
            // is set to loop only if the number chosen by the user is not = 0
            if (userNum == 1)
            {
                PrintWeekends();
            }
            else if (userNum == 2)
            {
                PrintNights();
            }
        }

        private void PrintWeekends()
        {
            Console.WriteLine("\n NIGHTS TO WORK:");

            int currWeekCount = 0;

            // The for loop continues from 1 to 52 but only prints every 4th week
            // It also has a "currWeekCount" which breaks the line in to a new one
            // after it has printed 4 times
            for (int week = 1; week <= 52; week += 4)
            {
                currWeekCount++;

                Console.Write(" {0,-6}{1,2:d}  ", "Week", week);

                if (currWeekCount % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("                                         |");
            Console.WriteLine("------------------------------------------\n");
        }

        private void PrintNights()
        {
            Console.WriteLine("\n NIGHTS TO WORK:");

            int currWeekCount = 0;

            // The for loop continues from 1 to 52 but only prints every 2nd week
            // It also has a "currWeekCount" which breaks the line in to a new one
            // after it has printed 4 times
            for (int week = 1; week <= 52; week += 2)
            {
                currWeekCount++;

                Console.Write(" {0,-6}{1,2:d}  ", "Week", week);

                if (currWeekCount % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n\n------------------------------------------");
            Console.WriteLine("                                         |");
            Console.WriteLine("------------------------------------------\n");
        }
    }
}
