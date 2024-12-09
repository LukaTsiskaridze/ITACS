namespace Exercise_3
{
    internal class _3_5
    {
        public static void WeekFromNumba()
        {
            Console.WriteLine("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int weekDay = day % 7;

            switch (weekDay)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }

    }
}
