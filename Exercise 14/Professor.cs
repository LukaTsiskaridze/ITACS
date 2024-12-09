using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_1_2
{
    internal class Professor : Person
    {
        public Professor(string name) : base(name)
        {
        }
        public void Explain()
        {
            Console.WriteLine($"{Name} is explaining");
        }
    }
}
