namespace KidsFair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleVisuals();

            petObj();
            albumObj();
            ticketsellerObj();
        }

        static void petObj()
        {
            // Creating a pet object
            Pet pet = new Pet();
            // Calling a method of the object to run
            pet.Start();

            // Writing the text in console and reading input
            Console.WriteLine("Press Enter for the next part!");
            Console.ReadLine();
        }

        static void albumObj()
        {
            // Creating an album object
            Album album = new Album();
            // Calling a method of the object to run
            album.Start();

            // Writing the text in console and reading input
            Console.WriteLine("Press Enter for the next part!");
            Console.ReadLine();
        }

        static void ticketsellerObj()
        {
            // Creating a ticketseller object
            TicketSeller ticketseller = new TicketSeller();
            // Calling a method of the object to run
            ticketseller.Start();

            // Writing the text in console and reading input
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }

        static void ConsoleVisuals()
        {
            // Making the console look different
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();  // Using the above color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "KIDS' FAIR";
        }
    }
}