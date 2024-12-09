namespace Exercise_11
{
    class _11_4
    {
        public static void GetBinaryPrint()
        {
            Console.WriteLine("Enter a decimal number:");
            int number = int.Parse(Console.ReadLine());

            string binaryRepresentation = GetBinaryRepresentationRec(number);
            Console.WriteLine($"Binary representation: {binaryRepresentation}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static string GetBinaryRepresentationRec(int number)
        {
            if (number == 0)
            {
                return "0";
            }
            if (number == 1)
            {
                return "1";
            }

            return GetBinaryRepresentationRec(number / 2) + (number % 2).ToString();
        }
    }
}
