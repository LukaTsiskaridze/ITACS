namespace Exercise_5
{
    class _5_3
    {
        public static void TargetSum()
        {
            int[] arr = { 3, 5, -4, 8, 11, 1, -1, 6 };

            Console.WriteLine("Enter the target sum: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} is {number}");
                    }
                }
            }
        }
    }
}
