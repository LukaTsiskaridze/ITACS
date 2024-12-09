namespace Exercise_14_1_2
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
        public void Greet()
        {
            Console.WriteLine("hello");
        }
        public int SetAge(int age)
        {
            return age;
        }
}
}