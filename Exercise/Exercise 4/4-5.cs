namespace Exercise_4
{
    class _4_5
    {
        public static void Factorial()
        {
            Console.WriteLine("Factorial of wha: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
