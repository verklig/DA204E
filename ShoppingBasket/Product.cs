using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    internal class Product
    {
        private string name;
        private double price;
        private int count;

        private double amountToPay;

        public void ReadInput()
        {
            ReadName();
            ReadPrice();
            ReadQuantity();
        }

        public void ReadName()
        {
            Console.WriteLine("What's the name of the product you'd like to buy? ");

            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Okay " + name + ".");
        }

        private void ReadPrice()
        {
            Console.WriteLine("What price would you want to pay? ");
            string strPrice = Console.ReadLine();
            price = double.Parse(strPrice);
            Console.WriteLine();
            Console.WriteLine("The price of " + name + " is " + "$" + price + ".");
        }

        private void ReadQuantity()
        {
            Console.WriteLine("How many? ");
            string strQuantity = Console.ReadLine();
            count = int.Parse(strQuantity);
            Console.WriteLine();
            Console.WriteLine("Okay " + count + ".");
        }

        private void CalculateAmountToPay()
        {
            amountToPay = price * count;
        }

        private void PrintRecipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" *****     Recipt      *****");
            Console.WriteLine();

            Console.WriteLine("Product      :       " + name);
            Console.WriteLine("Unit price   :       " + "$" + price);
            Console.WriteLine("Quantity     :       " + count);
            Console.WriteLine();

            Console.WriteLine("Amount to pay:      " + amountToPay.ToString("$" + "0.00"));
            Console.WriteLine();
            Console.WriteLine(" *****  Welcome back!  *****");
        }

        public void Start()
        {
            ReadInput();
            CalculateAmountToPay();
            PrintRecipt();
        }

        public void End()
        {
            Console.ReadLine();
        }
    }
}
