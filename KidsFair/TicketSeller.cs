using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class TicketSeller
    {
        private string name;
        private double price = 20;
        private int numOfAdults;
        private int numOfChildren;

        private double amountToPay;

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to KIDS' FAIR!" + "\n" + "Children always get a 75% discount!");
            Console.WriteLine();

            ReadAndSaveTicketData();
            ShowReceipt();
        }

        private void ReadAndSaveTicketData()
        {
            ReadName();
            ReadNumOfAdults();
            ReadNumOfChildren();
            CalculatePrice();
        }

        private void ShowReceipt()
        {
            // Writes text out to the console containing the receipt and amount to pay
            Console.WriteLine(" +++++ Your receipt +++++" + "\n" + " Amount to pay = $" + amountToPay);
            Console.WriteLine(" +++++ Thank you " + name + ", welcome back! +++++");
            Console.WriteLine(); // Blank line
        }

        private void ReadName()
        {
            // Reads the name put in by user
            Console.WriteLine("Your name please:" + "\n");

            name = Console.ReadLine();
            Console.WriteLine();
        }

        private void ReadNumOfAdults()
        {
            // Reads the number of adults put in by user
            Console.WriteLine("Number of adults:" + "\n");

            numOfAdults = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        private void ReadNumOfChildren()
        {
            // Reads the number of children put in by user
            Console.WriteLine("Number of children:" + "\n");

            numOfChildren = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        private void CalculatePrice()
        {
            // Calculates the price depending on how many adults and children there are
            amountToPay = price * numOfAdults + (price * 0.25 * numOfChildren);
        }
    }
}
