using System;

namespace Exercise_6
{
    class _6_4
    {
        public static void PrimeOrComposite(int number)
        {
            if (number < 2)
            {
                Console.WriteLine("Neither");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Composite");
            }
        }
    }
}
