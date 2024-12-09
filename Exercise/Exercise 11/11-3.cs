namespace Exercise_11
{
    class _11_3
    {
        public static void PermutationsPrint()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number {i + 1}:");
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine("All possible permutations:");
            List<List<int>> permutations = GetPermutations(numbers, 0);
            foreach (var permutation in permutations)
            {
                Console.WriteLine(string.Join("", permutation));
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static List<List<int>> GetPermutations(List<int> numbers, int start)
        {
            List<List<int>> result = new List<List<int>>();

            if (start == numbers.Count - 1)
            {
                result.Add(new List<int>(numbers));
                return result;
            }

            for (int i = start; i < numbers.Count; i++)
            {
                Swap(numbers, start, i);
                result.AddRange(GetPermutations(numbers, start + 1));
                Swap(numbers, start, i);
            }

            return result;
        }

        static void Swap(List<int> numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }
}
