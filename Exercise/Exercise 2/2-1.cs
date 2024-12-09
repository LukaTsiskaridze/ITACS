namespace Exercise_2
{
        class _2_1
        {
            public static void SumOfDoubles()
            {
                Console.Write("*Sum of doubles*\nEnter first double: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second double: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                double sum = number1 + number2;
                Console.WriteLine("Sum of {0} and {1} is {2}", number1, number2, sum);
            
            }
        }
}
