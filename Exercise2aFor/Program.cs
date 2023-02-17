namespace Exercise2aFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise2a - for statement";

            // Creating an object for the "ForStatements" class
            ForStatements forstatements = new ForStatements();
            forstatements.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}