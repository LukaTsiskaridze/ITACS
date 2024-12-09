using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_1_2
{
    internal class Student: Person
    {
        public Student(string name) : base(name)
        {
        }
        public void Study()
        {
            Console.WriteLine($"{Name} is studying");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine($"I'm {age} years old");
        }
    }
}
