using System;

namespace Inheritance
{
    class Truck : Vehicle
    {
        private int CargoCapacity { get; set; }
        
        public Truck(string make, string model, int year, int cargoCapacity) : base(make, model, year)
        {
            CargoCapacity = cargoCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
        }
    }
}
