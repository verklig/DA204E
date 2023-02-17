using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2aFor
{
    internal class ForStatements
    {
        /// <summary>
        /// This method calls three other methods to perform
        /// different calculations using the for-statement
        /// </summary>

        public void Start()
        {
            SumNumbers();
            SumNumbersFromOneTo();
            SumNumbersFromZeroTo();
        }

        public void SumNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of 1 to 20 is: " + sum);
            Console.WriteLine();
        }

        public void SumNumbersFromOneTo()
        {
            int userNumber;
            int sum = 0;

            Console.Write("Sum up the numbers from 1 to x.\nGive x: ");
            string str = Console.ReadLine();
            userNumber = int.Parse(str);

            for (int i = 1; i <= userNumber; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of 1 to " + userNumber + " is: " + sum);
            Console.WriteLine();
        }

        public void SumNumbersFromZeroTo()
        {
            int userNumber;
            int sum = 0;

            Console.Write("Sum up the numbers from 0 to -x.\nGive x: ");
            string str = Console.ReadLine();
            userNumber = int.Parse(str);

            for (int i = 1; i <= userNumber; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of 0 to -" + userNumber + " is: -" + sum);
            Console.WriteLine();
        }
    }
}
