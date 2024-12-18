namespace Exercise_20
{
    class _20_3
    {
        public static void HashtableFreq()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            Hashtable wordCount = new Hashtable();

            // იყავით სიტყვების განლაგება და მათი გაცემული სიხშირე
            string[] words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word] = (int)wordCount[word] + 1;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            // დაბეჭდეთ სიტყვების სიხშირეები
            foreach (DictionaryEntry entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }