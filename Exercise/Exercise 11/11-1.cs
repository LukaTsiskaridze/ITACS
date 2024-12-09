namespace Exercise_11
{
    class _11_1
    {
        public static void PrintNumbers()
        {
            Console.WriteLine("Enter numbers without spaces:");
            string input = Console.ReadLine();

            PrintNumbersRec(input, 0);

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        private static void PrintNumbersRec(string input, int index)
        {
            if (index >= input.Length)
            {
                return;
            }

            Console.Write(input[index] + " ");
            PrintNumbersRec(input, index + 1);
        }
    }
}
