using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// This class asks the user for some information about themselves and prints it to the console
    /// it also asks the user to choose a day in the week and displays a message depending on what day the user chose
    /// and calculates the length of a text given by the user and prints the character length to the console
    /// At the end it asks if the user wants to repeat the fortune teller and text length test again
    /// </summary>
    internal class FunFeatures
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string userText = "";

        public void Start()
        {
            // Get information from user
            Info();

            bool repeat = false;
            do
            {
                // Calling a method that reads a number between 1 and 7 and
                // displays the number given as a day in the week with a comment
                FortuneTeller();

                // Calling a method to calculate the length of a given text
                CalculateTextLength();

                repeat = DoAgain();
            } while(repeat);
        }

        private void Info()
        {
            // Information about me
            Console.WriteLine("My name is Eric and I am a student of the VT2023 semester!");
            Console.WriteLine();

            // Asks information about the user
            Console.WriteLine("Let me know about yourself!");

            Console.Write("First name: ");
            firstName = Console.ReadLine();

            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.WriteLine();

            // Prints it out to the console with the last name as capital letters
            lastName = lastName.ToUpper();
            Console.WriteLine("Nice to meet you " + lastName + ", " + firstName);
            Console.WriteLine("Your email is " + email);
            Console.WriteLine();

            Console.WriteLine("Press Enter for the next part!");
            Console.ReadLine();
            Console.Clear();
        }

        private void FortuneTeller()
        {
            bool done = false;

            Console.WriteLine("++++++++ FORTUNE TELLER ++++++++");

            // Repeats everything inside its own brackets "while" it's not "done"
            while (!done)
            {
                Console.Write("Select a number between 1 and 7: ");

                // Setting the input from user to a string and converting it into an integer
                string str = Console.ReadLine();
                int day = int.Parse(str);

                // Reads numbers between 1 and 7 and gives a comment
                // any other number also gives a comment but also restarts the "while"
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Today is Monday, you have assignments to work on!\n");
                        break;
                    case 2:
                        Console.WriteLine("Today is Tuesday, don't skip out on working out today!\n");
                        break;
                    case 3:
                        Console.WriteLine("Today is Wednesday, you are feeling lazy!\n");
                        break;
                    case 4:
                        Console.WriteLine("Today is Tursday, it's your lucky day!\n");
                        break;
                    case 5:
                        Console.WriteLine("Today is Friday, get ready for the weekend!\n");
                        break;
                    case 6: 
                        Console.WriteLine("Today is Saturday, it's your day to relax and do nothing!\n");
                        break;
                    case 7:
                        Console.WriteLine("Today is Sunday, don't sweat it's soon Monday!\n");
                        break;
                    default:
                        Console.WriteLine("An imaginary day is a good day, but I need a real day!\n");
                        break;
                }

                // If the day set by the user is more than 0 and less than or equal to 7
                // the statement is true, otherwise false repeating the "while"
                if (day > 0 && day <= 7)
                {
                    done = true;
                }
                else
                {
                    done = false;
                }
            }
            Console.WriteLine("Press Enter for the next part!");
            Console.ReadLine();
            Console.Clear();
        }

        private void CalculateTextLength()
        {
            // Tests the length of the text given by the user and
            // prints it to the console
            Console.WriteLine("++++++++ STRENGTH LENGTH ++++++++");
            Console.WriteLine("Write a text with any number of characters and press Enter.");
            Console.WriteLine("You can even copy text from a file and paste it here!");
            Console.WriteLine();

            userText = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(userText.ToUpper());
            int userTextLength = userText.Length;

            Console.WriteLine("Number of characters: " + userTextLength);
        }

        private bool DoAgain()
        {
            bool answer = false;
            bool done = true;

            // Asks if the user want to repeat the fortune teller and text length test
            // Anything starting with "y" is considered true and
            // anything starting with "n" is considered false
            // if anything else it gives an error message and repeats the loop
            do
            {
                Console.Write("\nDo you want to do fortune teller and text length test again? (y/n): ");

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

            } while (!done);

            return answer;
        }
    }
}
