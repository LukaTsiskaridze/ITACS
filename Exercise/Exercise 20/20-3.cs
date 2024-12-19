using System.Collections;

namespace Exercise_20{
    class _20_3
    {
        public static void CalculateWordFrequency()
        {
            Console.Write("Enter the path of the text file: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string text = File.ReadAllText(filePath);
            string[] words = text.Split(new[] { ' ', '\n', '\r', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Hashtable wordCount = new Hashtable();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (wordCount.ContainsKey(lowerWord))
                {
                    wordCount[lowerWord] = (int)wordCount[lowerWord] + 1;
                }
                else
                {
                    wordCount[lowerWord] = 1;
                }
            }

            Console.WriteLine("Word Frequencies:");
            foreach (DictionaryEntry entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
