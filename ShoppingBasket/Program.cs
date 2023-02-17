using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Eric's magic shop";
            Console.WriteLine("Welcome to my shop!");

            Product product = new Product();

            product.Start();

            product.End();
        }
    }
}