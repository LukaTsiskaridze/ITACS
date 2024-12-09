namespace Exercise_5
{
    class _5_1
    {
        public static void ArrayCopy()
        {
            int[] arr1 = { 15, 10, 12 };
            int[] arr2 = new int[3];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            foreach (int element in arr2)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
