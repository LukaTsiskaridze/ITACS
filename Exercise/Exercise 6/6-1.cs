namespace Exercise_6
{
    class _6_1
    {
        public static void SpaceCounter(string text)
        {
            int spaceCount = 0;

            foreach (char space in text)
            {
                if (space == ' ')
                {
                    spaceCount++;
                }
            }
            Console.WriteLine($"There are {spaceCount} spaces in the text");
        }
    }
}
