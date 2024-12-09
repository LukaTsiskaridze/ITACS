using System;

namespace Inheritance
{
    // Derived class
    public class Motorcycle : Vehicle
    {
        // Additional property for Motorcycle
        public bool HasSidecar { get; set; }

        // Constructor for Motorcycle
        public Motorcycle(string make, string model, int year, bool hasSidecar)
            : base(make, model, year) // Call the base class constructor
        {
            HasSidecar = hasSidecar;
        }

        // Override the DisplayInfo method to include Motorcycle-specific details
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method
            Console.WriteLine($"Has Sidecar: {HasSidecar}");
        }
    }
}
