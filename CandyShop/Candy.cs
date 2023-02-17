using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CandyShop
{
    internal class Candy
    {
        private DateTime currentDateTime = new DateTime();

        private double lollipopsPrice = 0.5; // Price of lollipops
        private double sourCandyPrice = 1.99; // Price of sour candy
        private double licoriceCandyPrice = 2.99; // Price of licorice candy
        private double chipBagsPrice = 3.99; // Price of chips

        private int numOfLollipops; // Number of lollipops
        private int numOfSourCandy; // Number of sour candy
        private int numOfLicoriceCandy; // Number of licorice candy
        private int numOfChipBags; // Number of chips

        private double amountToPay; // Amount to pay

        public void Start()
        {
            ConsoleVisuals();

            Console.WriteLine();
            Console.WriteLine("Welcome to my candy shop!" + "\n" + "Press Enter to show stock and prices!");
            Console.ReadLine();
            Console.Clear();

            ShowStockAndReadCandyData();
            ShowReceipt();

        }

        private void ShowStockAndReadCandyData()
        {
            ShowStock();

            ReadNumOfLollipops();
            ReadNumOfSourCandy();
            ReadNumOfLicoriceCandy();
            ReadNumOfChipBags();

            CalculatePrice();
        }

        private void ShowReceipt()
        {
            // Writes text out to the console containing the receipt and amount to pay
            Console.WriteLine("       +++++ Your receipt +++++" + "\n" + "        Amount to pay = $" + amountToPay);
            Console.WriteLine(" +++++ Thank you" + ", welcome back! +++++");
            Console.WriteLine(); // Blank line
        }

        private void ShowStock()
        {
            // Shows the stock and prices for products
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("Lollipop: $" + lollipopsPrice + "\n" + "Bag of sour candy: $" + sourCandyPrice + "\n" + "Bag of licorice candy: $" + licoriceCandyPrice + "\n" + "Bag of chips: $" + chipBagsPrice);
            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("Press Enter to select which and how many of the products you want!");
            Console.ReadLine();
            Console.Clear();
        }

        private void ReadNumOfLollipops()
        {
            // Reads the number of lollipops put in by user
            Console.WriteLine("Number of Lolipops:" + "\n");

            numOfLollipops = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
        }

        private void ReadNumOfSourCandy()
        {
            // Reads the number of sour candy bags put in by user
            Console.WriteLine("Number of sour candy bags:" + "\n");

            numOfSourCandy = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
        }

        private void ReadNumOfLicoriceCandy()
        {
            // Reads the number of licorice candy bags put in by user
            Console.WriteLine("Number of licorice candy bags:" + "\n");

            numOfLicoriceCandy = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
        }

        private void ReadNumOfChipBags()
        {
            // Reads the number of chip bags put in by user
            Console.WriteLine("Number of chip bags:" + "\n");

            numOfChipBags = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
        }

        private void CalculatePrice()
        {
            // Calculates the price of the products depending on amount chosen by the user
            amountToPay = lollipopsPrice * numOfLollipops + sourCandyPrice * numOfSourCandy + licoriceCandyPrice * numOfLicoriceCandy + chipBagsPrice * numOfChipBags;
        }

        private void ConsoleVisuals()
        {
            // Making the console look different
            currentDateTime = DateTime.Now; // Shows current date and time
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();  // Using the above color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Candy Shop " + currentDateTime;
        }
    }
}
