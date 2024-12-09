namespace Exercise_3
{
    class _3_3
    {
        public static void MN()
        {
            Console.WriteLine("-1 || 0 || 1: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
            {
                int n = 1;
                Console.WriteLine($"n is {n}");
            }
            else if (m == 0)
            {
                int n = 0;
                Console.WriteLine($"n is {n}");
            }
            else
            {
                int n = -1;
                Console.WriteLine($"n is {n}");
            }
        }
    }
}
