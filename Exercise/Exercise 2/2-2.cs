namespace Exercise_2
{
    class _2_2
    {
            public static void MultipleOfDoubles()
            {
                Console.Write("*Multiply true false*\nEnter first integer: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                int result = number1 * number2;
                bool isMore = result > 10;

                if (result > 10)
                {
                    Console.WriteLine($"{result} > 10 is {isMore}");
                }
                else
                {
                    Console.WriteLine($"{result} <= 10 is {isMore}");
                }

            }
        }
    }

