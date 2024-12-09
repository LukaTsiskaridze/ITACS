namespace Exercise_5
{
    class _5_2
    {
        public static void ArrayJoin()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] arr3 = new int[6];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[i + 3] = arr2[i];
            }
            foreach (int element in arr3)
            {
                Console.Write($"{element} ");
            }
        }
    }
}