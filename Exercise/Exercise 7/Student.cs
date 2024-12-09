using System;

namespace Exercise_7
{
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int studentId { get; set; }
        public int groupId { get; set; }

        public Student(string name, string surname, int age, int studentId, int groupId)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.studentId = studentId;
            this.groupId = groupId;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{name} {surname} is {age} years old, ID #{studentId} Group #{groupId}");
        }
    }
}
