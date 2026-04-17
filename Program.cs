  using System;

namespace Properties_Drake_Boswell
{
    // This is the main program class that contains the entry point of the application.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Car class
            Car car = new Car();
           car.Make = "Toyota";
           car.Model = "Camry";

           Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");
            // Create another instance of the Car class
            Car car2 = new Car();
           car2.Make = "Honda";
           car2.Model = "Civic";

           Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

           // Create a third instance of the Car class
           Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
