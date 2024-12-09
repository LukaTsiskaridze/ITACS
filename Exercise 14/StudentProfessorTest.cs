using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14_1_2
{
    internal class StudentProfessorTest
    {
        public static void Main()
        {
            Person[] people = new Person[3];

            Console.WriteLine("Person? ");
            people[0] = new Person(Console.ReadLine());

            Console.WriteLine("Student? ");
            people[1] = new Student(Console.ReadLine());

            Console.WriteLine("Professor? ");
            people[2] = new Professor(Console.ReadLine());

            foreach (Person person in people)
            {
                Console.WriteLine(person);
                if (person is Student student)
                {
                    student.Study();
                }
                else if (person is Professor professor)
                {
                    professor.Explain();
                }
            }
        }
    }
}
