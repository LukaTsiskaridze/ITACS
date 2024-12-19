namespace Exercise_20
{
public static class _20_2
    {
        private static Queue<string> queue = new Queue<string>();

        public static void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string customer = Console.ReadLine();
            queue.Enqueue(customer);
            Console.WriteLine($"{customer} has been added to the queue.");
        }

        public static void ServeCustomer()
        {
            if (queue.Count > 0)
            {
                string servedCustomer = queue.Dequeue();
                Console.WriteLine($"{servedCustomer} has been served.");
            }
            else
            {
                Console.WriteLine("No customers in the queue.");
            }
        }

        public static void ViewQueue()
        {
            if (queue.Count > 0)
            {
                Console.WriteLine("Customers in queue:");
                foreach (string customer in queue)
                {
                    Console.WriteLine(customer);
                }
            }
            else
            {
                Console.WriteLine("The queue is empty.");
            }
        }
    }
}
