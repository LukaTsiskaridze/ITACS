namespace Exercise_20
{
    class _20_4
    {
        public static void ArrList()
        {
            ArrayList students = new ArrayList();

            // დამატება სტუდენტების სიაში
            students.Add("Student 1");
            students.Add("Student 2");
            students.Add("Student 3");

            // ამოიღეთ სტუდენტი სიიდან
            Console.WriteLine("Take student:");
            int indexToRemove = Convert.ToInt32(Console.ReadLine());

            if (indexToRemove >= 0 && indexToRemove < students.Count)
            {
                students.RemoveAt(indexToRemove);
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Wrong index.");
            }

            // დაბეჭდეთ ყველა სტუდენტი, რომელიც ამჟამად სიაშია
            Console.WriteLine("Students left in list:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}