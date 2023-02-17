namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Strings, selection and iteration in C#";
            Console.ForegroundColor = ConsoleColor.Yellow;
            FunFeatures funObj = new FunFeatures();
            funObj = Start();
        }
    }
}