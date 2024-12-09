namespace Exercise_11
{
    class _11_6
    {
        public static void ToPowRec()
        {
            Console.WriteLine("Enter the base number:");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power number:");
            int powerNumber = int.Parse(Console.ReadLine());

            int result = Power(baseNumber, powerNumber);
            Console.WriteLine($"{baseNumber} raised to the power of {powerNumber} is: {result}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static int Power(int baseNumber, int powerNumber)
        {
            if (powerNumber == 0)
            {
                return 1;
            }

            return baseNumber * Power(baseNumber, powerNumber - 1);
        }
    }
}
