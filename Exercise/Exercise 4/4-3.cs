namespace Exercise_4
{
    class _4_3
    {
        public static void RightPyramid()
        {
            Console.WriteLine("Size of right pyramid: ");
            int size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
