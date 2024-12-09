using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter dawg name: ");
            string name = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(name);

            Console.WriteLine($"I named the dawg {dog.GetName()}");
            dog.Eat();

        }
    }
}
