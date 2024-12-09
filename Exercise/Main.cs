using Exercise_3;
using Exercise_4;
using Exercise_5;
using Exercise_6;
using Exercise_9.Homework.@ref;
using Exercise_9.Homework.@val;
using Exercise_9;
using Exercise_10;
using Exercise_19;
using System;
using System.Reflection;
using static Exercise_10.Program;

namespace Exercise
{
    class Program
    {
         static void Main()
        {
            // Exercise 2:

            //_2_1.SumOfDoubles();
            //_2_2.MultipleOfDoubles();
            //_2_3.EvenOrNah();



            // Exercise 3:
            //_3_1.PosOrNeg();
            //_3_2.Vote();
            //_3_3.MN();
            //_3_4.LargestOuttaThree();
            //_3_5.WeekFromNumba();
            //_3_6.BrokenCalculeita();



            // Exercise 4:
            //_4_1.SumLoop();
            //_4_2.Tabula();
            //_4_3.RightPyramid();
            //_4_4.HoleTriangle();
            //_4_5.Factorial();
            //_4_6.HoleTriangleNumbered();



            // Exercise 5:
            //_5_1.ArrayCopy();
            //_5_2.ArrayJoin();
            //_5_3.TargetSum();



            // Exercise 6:
            //_6_1.SpaceCounter("Welcome to Step Academy");
            //_6_2.ToPowski(12, 2);
            //_6_3.FibonacciIndex(0);
            //_6_4.PrimeOrComposite(4);



            // Exercise 7:



            // Exercise 9:

            //Class1 class1 = new Class1();
            //Struct1 struct1 = new Struct1();

            //ChangeInstance changer = new ChangeInstance();

            //changer.ChangeInstanceMethod(class1);
            //Console.WriteLine($"Class1 x: {class1.x}");

            //changer.ChangeInstanceMethod(ref struct1);
            //Console.WriteLine($"Class1 x: {struct1.y}");

            //Struct2 struct2;

            //struct2.x = 10;
            //struct2.y = 20;

            //Console.WriteLine($"Struct2: x = {struct2.x}, y = {struct2.y}");

            //Struct3 struct3_1 = new Struct3();
            //Console.WriteLine($"Struct3 (default): x = {struct3_1.x}, y = {struct3_1.y}");

            //Struct3 struct3_2 = new Struct3(10, 30);
            //Console.WriteLine($"Struct3 (default): x = {struct3_2.x}, y = {struct3_2.y}");

            //Console.WriteLine();

            //DateTime date = new DateTime(2016, 6, 8, 11, 49, 0);
            //Console.WriteLine($"Complete date: {date}");
            //Console.WriteLine($"Shorter: {date.ToShortDateString()}");
            //Console.WriteLine($"24-hour format: {date:dd/MM/yyyy HH:mm}");

            //Console.WriteLine();

            //DateTime date2 = new DateTime(2016, 7, 11);
            //Console.WriteLine($"{date2.ToShortDateString()} is {date2.DayOfWeek}");

            //DateTime today = DateTime.Now;

            //Console.WriteLine();

            //Console.WriteLine($"General format: {today}");
            //Console.WriteLine($"Date only: {today.ToShortDateString()}");
            //Console.WriteLine($"Full Date: {today:dd}");
            //Console.WriteLine($"Time: {today:hh:mm tt}");

            //Console.WriteLine();

            //DateTime futureDate = today.AddDays(40);

            //Console.WriteLine($"Today: {today.DayOfWeek}");
            //Console.WriteLine($"40 days from today: {futureDate.DayOfWeek}");



            // Exercise 10:
           // Employ[] employees = new Employ[]
           //{
           //     new Employ("John", "Doe", new DateTime(1990, 1, 1), Country.USA, Gender.Male, Contacts.Email),
           //     new Employ("Jane", "Smith", new DateTime(1992, 2, 2), Country.USA, Gender.Female, Contacts.Phone),
           //     new Employ("Alice", "Johnson", new DateTime(1985, 3, 3), Country.England, Gender.Female, Contacts.Fax),
           //     new Employ("Bob", "Brown", new DateTime(1988, 4, 4), Country.England, Gender.Male, Contacts.Address),
           //     new Employ("Charlie", "Davis", new DateTime(1995, 5, 5), Country.France, Gender.Male, Contacts.Postal_Code),
           //     new Employ("Diana", "Miller", new DateTime(1993, 6, 6), Country.France, Gender.Female, Contacts.Email),
           //     new Employ("Eve", "Wilson", new DateTime(1987, 7, 7), Country.Georgia, Gender.Female, Contacts.Phone),
           //     new Employ("Frank", "Moore", new DateTime(1991, 8, 8), Country.Georgia, Gender.Male, Contacts.Fax)
           //};
           // Employ.PrintEmployeesFromSameCountry(employees, Country.USA);



            // Exercise 11:

            //_11_1.PrintNumbersRecursively();
            //_11_2.IsPalindromeRecursiveThoPrint();
            //_11_3.PermutationsPrint();
            //_11_4.GetBinaryPrint();
            //_11_5.InvertStringPrint();
            //_11_6.ToPowRec();



            // Exercise 19:

            Generic<string, int> example = new Generic<string, int>("Hello", 5);

            example.PrintAndReturn("Hello, World");
            example.PrintAndReturn(123);
            example.PrintAndReturn(45.67);

            example.UreturnT("Hello", 5);

            Generic<int[], int> arrayExample = new Generic<int[], int>(new int[] { 1, 2, 3 }, 5);

            arrayExample.PrintAndReturn(new int[] { 1, 2, 3 });
            arrayExample.PrintAndReturn(123);
            arrayExample.PrintAndReturn(45.67);

            Generic<string, bool> stringBoolExample = new Generic<string, bool>("Hello", true);

            stringBoolExample.PrintAndReturn("Hello, World");
            stringBoolExample.PrintAndReturn(123);
            stringBoolExample.PrintAndReturn(45.67);

            string result = stringBoolExample.UreturnT("Hello", true);
            Console.WriteLine($"Returned value: {result}");
        }
    }
}