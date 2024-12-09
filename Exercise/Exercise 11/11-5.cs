namespace Exercise_11
{
    class _11_5
    {
        static void InvertStringPrint()
        {
            Console.WriteLine("Enter a string to invert:");
            string input = Console.ReadLine();

            string invertedString = InvertStringRec(input);
            Console.WriteLine($"Inverted string: {invertedString}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static string InvertStringRec(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }

            return input[input.Length - 1] + InvertStringRec(input.Substring(0, input.Length - 1));
        }
    }
}
