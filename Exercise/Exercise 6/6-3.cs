using System;

namespace Exercise_6
{
    class _6_3
    {
        public static void FibonacciIndex(int index)
        {
            int a = 0; int b = 1; int c = 0;

            for (int i = 0; i < index-2; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);
        }
    }
}
