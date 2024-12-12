namespace Exercise_20
{
    class _20_2
    {
        public static void Fifo()
        {
            Queue<string> queue = new Queue<string>();

            // დაამატეთ კლიენტების სახელები რიგში
            queue.Enqueue("Client 1");
            queue.Enqueue("Client 2");
            queue.Enqueue("Client 3");

            // ემსახურება მომხმარებელს FIFO პრინციპით
            Console.WriteLine("Last client: " + queue.Peek());

            while (queue.Count > 0)
            {
                Console.WriteLine("Serves: " + queue.Dequeue());
            }
        }
}