using System;

namespace Inheritance
{
    // Base class
    public class Vehicle
    {
        // Common properties for all vehicles
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Constructor for Vehicle
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Make} {Model}");
        }
    }
}
