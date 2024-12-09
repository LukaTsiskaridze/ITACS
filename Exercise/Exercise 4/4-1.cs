namespace Exercise_4
{
     class _4_1
    {
        public static void SumLoop()
        {
            Console.WriteLine("Sum up to: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            Console.Write("The natural numbers being summed: ");
            for (int currentNumber = 1; currentNumber <= upperLimit; currentNumber++)
            {
                Console.Write(currentNumber);

                if (currentNumber < upperLimit)
                {
                    Console.Write(" ");
                }

                sum += currentNumber;
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of these numbers is: {sum}");
        }
    }
}
