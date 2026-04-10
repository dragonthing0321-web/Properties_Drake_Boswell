  using System;

namespace Properties_Drake_Boswell
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
           car.Make = "Toyota";
           car.Model = "Camry";

           Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");
           
           Car car2 = new Car();
           car2.Make = "Honda";
           car2.Model = "Civic";

           Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

           Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
