namespace Exercise_4
{
    class _4_6
    {
        public static void HoleTriangleNumbered()
        {
            Console.WriteLine("Size of numbered hole triangle: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                for (int j = size - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
