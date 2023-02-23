namespace Assignment2
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            ConsoleVisuals();

            // Start FunFeatures
            Console.Title = "Strings, selection and iteration in C#";
            FunFeatures funObj = new FunFeatures();
            funObj.Start();

            NextPart(); //Calls the NextPart method below

            // Start MathWork
            Console.Title = "Let's work with numbers!";
            MathWork mathObj = new MathWork();
            mathObj.Start();

            NextPart();

            // Start TempConverter
            Console.Title = "Celsius and Fahrenheit converter";
            TempConverter tempObj = new TempConverter();
            tempObj.Start();

            NextPart();

            // Start WorkSchedule
            Console.Title = "Working schedule";
            WorkSchedule workObj = new WorkSchedule();
            workObj.Start();

            ExitProgram();
        }
        
        private static void ExitProgram()
        {
            Console.WriteLine("\n Exiting program...");
        }

        private static void NextPart()
        {
            Console.WriteLine("\nPress Enter for the next part!");
            Console.ReadLine();
            Console.Clear();
        }

        private static void ConsoleVisuals()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}