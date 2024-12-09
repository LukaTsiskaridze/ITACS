namespace Exercise_3
{
    class _3_6
    {
        public static void BrokenCalculeita()
        {
            Console.WriteLine("num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string result = num1 == num2 ? $"They're even, so: {(num1+num2)*3}" : $"Uneven, so: {num1 + num2}";
            Console.WriteLine(result);
        }
    }
}
