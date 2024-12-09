namespace Exercise_3
{
    class _3_4
    {
        public static void LargestOuttaThree()
        {
            Console.WriteLine("num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num1");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num1");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Largest of three: {Math.Max(num1, Math.Max(num2, num3))}");
        }
        
    }
}
