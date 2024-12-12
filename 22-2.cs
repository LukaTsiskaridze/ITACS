namespace Exercise_21
{
    class PrintJob
    {
        public string JobName { get; set; }
        public int Pages { get; set; }

        public PrintJob(string jobName, int pages)
        {
            JobName = jobName;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"{JobName}, {Pages} pages";
        }
    }

    class Program
    {
        static void JobPrinta()
        {
            Queue<PrintJob> printQueue = new Queue<PrintJob>();

            // დაამატეთ სამუშაოები რიგში
            printQueue.Enqueue(new PrintJob("Document 1", 5));
            printQueue.Enqueue(new PrintJob("Document 2", 3));
            printQueue.Enqueue(new PrintJob("Document 3", 10));

            // გააუქმეთ რიგში პირველი სამუშაო
            Console.WriteLine("გამოიყენეთ 'q' სამუშაოს გასაუქმებლად და 'd' შემდეგი სამუშაოს დასაბეჭდად.");
            string command = Console.ReadLine();

            if (command.ToLower() == "q" && printQueue.Count > 0)
            {
                PrintJob cancelledJob = printQueue.Dequeue();
                Console.WriteLine($"დავალება გაუქმებულია: {cancelledJob}");
            }

            // დაბეჭდეთ შემდეგი სამუშაო
            if (printQueue.Count > 0)
            {
                PrintJob nextJob = printQueue.Peek();
                Console.WriteLine($"შემდეგი დასაბეჭდი სამუშაო: {nextJob}");
            }
        }
    }