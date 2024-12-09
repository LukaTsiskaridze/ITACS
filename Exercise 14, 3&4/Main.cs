using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0);

            Console.WriteLine("How much we pourin'?");
            int gasoline = int.Parse(Console.ReadLine());

            car.Refuel(gasoline);
            car.Drive();
        }
    }
}
