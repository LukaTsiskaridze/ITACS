namespace Exercise_21
{
    class _22_3
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            Dictionary<char, int> letterFrequency = new Dictionary<char, int>();

            // დაანგარიშეთ ასოების სიხშირე
            foreach (char c in input.ToLower())
            {
                if (char.IsLetter(c))
                {
                    if (letterFrequency.ContainsKey(c))
                    {
                        letterFrequency[c]++;
                    }
                    else
                    {
                        letterFrequency[c] = 1;
                    }
                }
            }

            // დაბეჭდეთ ასოების სიხშირე
            Console.WriteLine("Char frequency:");
            foreach (var entry in letterFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}