namespace Exercise_20
{
    class _20_1
    {
        public static void StackReverse()
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            // შეიტანეთ თითოეული სიმბოლო სტეკში
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // ამოიღეთ სიმბოლოები სტეკიდან და შეაგროვეთ შებრუნებული სტრიქონი
            string reversed = string.Empty;
            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            Console.WriteLine("Reversed string: " + reversed);
        }
    }

}