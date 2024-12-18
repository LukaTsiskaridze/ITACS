using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class _20_1
    {
        public string Reverse(string input)
        {
            Stack<char> stack = new Stack<char>();

            // Push each character onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Pop characters to reverse the string
            string reversed = string.Empty;
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            return reversed;
        }
    }

}
