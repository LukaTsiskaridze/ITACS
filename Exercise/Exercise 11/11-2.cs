namespace Exercise_11
{
     class _11_2
    {
        public static void IsPalindromeRecursiveThoPrint()
        {
            Console.WriteLine("Enter a string to check if it is a palindrome:");
            string input = Console.ReadLine();

            bool isPalindrome = IsPalindromeRecursiveTho(input, 0, input.Length - 1);
            Console.WriteLine($"Is the string a palindrome? {isPalindrome}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
        private static bool IsPalindromeRecursiveTho(string input, int left, int right)
        {
            if (left >= right)
            {
                return true;
            }

            if (input[left] != input[right])
            {
                return false;
            }

            return IsPalindromeRecursiveTho(input, left + 1, right - 1);
        }
    }
}
