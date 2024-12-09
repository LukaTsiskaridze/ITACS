using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car object
            Car car = new Car("Toyota", "Corolla", 2020, 4);
            car.DisplayInfo();

            Console.WriteLine();

            // Create a Motorcycle object
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2019, true);
            motorcycle.DisplayInfo();

            Console.WriteLine();

            Truck truck = new Truck("Ford", "Heavy Weight", 2021, 1500);
            truck.DisplayInfo();
        }
    }
}
