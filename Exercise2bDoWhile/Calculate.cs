using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2bDoWhile
{
    internal class Calculate
    {
        private double number;

        public void Start()
        {
            bool calcAgain = true;

            do
            {
                ReadNumber();
                CalculateRoot();

                calcAgain = CalculateAgain();
            } while (calcAgain);
        }

        private void ReadNumber()
        {
            Console.Write("Please write a valid number: ");

            string str = Console.ReadLine();
            number = double.Parse(str);
        }
    

        private void CalculateRoot()
        {
            if (number >= 0)
            {
                double root = Math.Sqrt(number);
                Console.WriteLine("The square root of " + number + " is: " + root.ToString("0.00"));
            }
            else
                Console.WriteLine("Must be a positive number!");
        }

        private bool CalculateAgain()
        {
            bool answer = false;
            bool done = true;

            Console.WriteLine();
            Console.Write("Do you want to continue? (y/n)");

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
                    Console.WriteLine("Please use y/n to answer!");
                    done = false;
                }

            } while (!done);
            
            return answer;
            
        }
    }
}
