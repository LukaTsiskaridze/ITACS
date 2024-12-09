namespace Exercise_4
{
    class _4_2
    {
        public static void Tabula()
        {
            Console.WriteLine("Multiplication table of: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number}*{i}={result}");
            }
        }
    }
}
