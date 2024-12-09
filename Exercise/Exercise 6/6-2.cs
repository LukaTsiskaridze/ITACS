namespace Exercise_6
{
    class _6_2
    {
        public static void ToPowski(int basenum, int pownum)
        {
            int result = 1;
            for (int i = 1; i <= pownum; i++)
            {
                result *= basenum;
            }
            Console.WriteLine(result);
        }
    }
}
