namespace Exercise_3
{
    class _3_1
    {
        public static void PosOrNeg()
        {
            Console.WriteLine("*Positive or negative*\nCheck sign of a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = number >= 0 ? $"{number} is positive" : $"{number} is negative";
            Console.WriteLine(result);
        }
    }
}
