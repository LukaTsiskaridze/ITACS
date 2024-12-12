namespace Exercise_21
{
    class _22_1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public _22_1(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }

    class Program
    {
        static void StudentList()
        {
            List<Student> students = new List<Student>();

            // დაამატეთ სტუდენტები სიაში
            students.Add(new Student("George", 20));
            students.Add(new Student("Anuki", 22));
            students.Add(new Student("Levan", 21));

            // ამოიღეთ სტუდენტი სიიდან
            Console.WriteLine("Enter student name index, to remove:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < students.Count)
            {
                students.RemoveAt(index);
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