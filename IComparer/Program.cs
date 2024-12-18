using System;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Age: {Age}";
    }
}

public class StudentsCompare : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
       if (x == null || y == null)
            throw new ArgumentException("Both students must be non-null");

            int result = string.Compare(x.FirstName, y.FirstName, StringComparison.Ordinal);
            if (result != 0)
                return result;
            
            result = string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
        if (result != 0)
            return result;

        return x.Age.CompareTo(y.Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var students = new SortedSet<Student>(new StudentsCompare())
        {

        new Student("Alice", "Smith", 20),
        new Student("Bob", "Johnson", 22),
        new Student("Alice", "Smith", 18),
        new Student("Charlie", "Brown", 20),
        new Student("Alice", "Smith", 20)
    };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}