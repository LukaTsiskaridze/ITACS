namespace Exercise_3
{
    class _3_2
    {
        public static void Vote()
        {
            Console.WriteLine("Ur age pls: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string eligible = age >= 18 ? "Vote ahead" : "gtfo";
            Console.WriteLine(eligible);
        }
    }
}
