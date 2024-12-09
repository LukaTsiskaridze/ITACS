using System;

namespace Polymorphism
{
    class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Main();

            Vehicle car = new Car();
            car.Main();

            Vehicle motorcycle = new Motorcycle();
            motorcycle.Main();

            Vehicle bicycle = new Bicycle();
            bicycle.Main();
        }
    }
    class Vehicle
    {
        public virtual void Main()
        {
            Console.WriteLine("Vroom vroom");
        }
    }
    class Car : Vehicle
    {
        public override void Main()
        {
        }
    }
    class Motorcycle : Vehicle
    {
        public override void Main()
        {
            Console.WriteLine("Brr brr");
        }
    }
    class  Bicycle : Vehicle
    {
        public override void Main()
        {
            Console.WriteLine("Clink clink");
        }
    }
}