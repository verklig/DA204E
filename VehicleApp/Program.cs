namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "VehicleApp";

            Console.WriteLine("Welcome to my first C# console app!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Car carObj = new Car();

            carObj.SetModel("BMW 535d 2006");
            carObj.SetHorsePower(285);
            carObj.Accelerate(120);

            Console.WriteLine(carObj.ToString());
            Console.WriteLine();

            Console.WriteLine("Stop the car now");
            carObj.Brake();
            Console.WriteLine();
            Console.WriteLine(carObj.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Bike bikeObj = new Bike();

            bikeObj.SetModel("Honda CRF 125f 2017");
            bikeObj.SetHorsePower(8);
            bikeObj.Accelerate(65);

            Console.WriteLine(bikeObj.ToString());
            Console.WriteLine();

            Console.WriteLine("Stop the bike now");
            bikeObj.Brake();
            Console.WriteLine();
            Console.WriteLine(bikeObj.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Truck truckObj = new Truck();

            truckObj.SetModel("Mercedes Sprinter 316 cdi 2013");
            truckObj.SetHorsePower(163);
            truckObj.Accelerate(100);

            Console.WriteLine(truckObj.ToString());
            Console.WriteLine();

            Console.WriteLine("Stop the truck now");
            truckObj.Brake();
            Console.WriteLine();
            Console.WriteLine(truckObj.ToString());

            Console.ReadLine();
        }
    }
}