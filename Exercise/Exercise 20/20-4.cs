using System.Collections;

namespace Exercise_20
{
    class _20_4
    {
        private static ArrayList students = new ArrayList();

        public static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string student = Console.ReadLine();
            students.Add(student);
            Console.WriteLine($"{student} has been added to the list.");
        }

        public static void RemoveStudent()
        {
            Console.Write("Enter student name to remove: ");
            string student = Console.ReadLine();

            if (students.Contains(student))
            {
                students.Remove(student);
                Console.WriteLine($"{student} has been removed from the list.");
            }
            else
            {
                Console.WriteLine($"{student} is not in the list.");
            }
        }

        public static void PrintStudents()
        {
            if (students.Count > 0)
            {
                Console.WriteLine("Students in the list:");
                foreach (string student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("The list is empty.");
            }
        }
    }
}
