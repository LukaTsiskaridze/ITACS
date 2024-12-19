using System;
using System.Collections.Generic;

namespace Exercise_20
{
    public static class _20_1
    {
        // Method to reverse the string
        public static string Reverse(string input)
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

        // Method to handle user input
        public static void ReverseUserInput()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine(); // Get input from the user

            string reversed = Reverse(input); // Call the Reverse method
            Console.WriteLine($"Reversed string: {reversed}"); // Output the reversed string
        }
    }
}
