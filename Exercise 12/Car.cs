using System;

namespace Inheritance
{
    // Derived class
    public class Car : Vehicle  
    {
        // Additional property for Car
        public int NumberOfDoors { get; set; }

        // Constructor for Car
        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year) // Call the base class constructor
        {
            NumberOfDoors = numberOfDoors;
        }

        // Override the DisplayInfo method to include Car-specific details
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
}
