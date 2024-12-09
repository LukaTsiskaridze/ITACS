namespace Exercise_4
{
    class _4_4
    {
        public static void HoleTriangle()
        {
            Console.WriteLine("Size of hole triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                    Console.WriteLine();
            }
        }
    }
}
