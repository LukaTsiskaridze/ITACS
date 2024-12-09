namespace Exercise_2
{
    class _2_3
    {
        public static void EvenOrNah()
        {
            Console.Write("*Sum even or odd*\nFirst numba: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("*Second numba: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            bool isEven = sum % 2 == 0;

            Console.WriteLine($"Is {sum} even?: {isEven}");
        }
    }
}
