namespace Exercise_10
{
    class Program
    {
        public enum Country
        {
            Georgia,
            England,
            France,
            USA
        }
        public enum Gender
        {
            Male,
            Female
        }
        public enum Contacts
        {
            Phone,
            Email,
            Fax,
            Address,
            Postal_Code
        }
        public class Employ
        {
            public string Name { get; set; }
            public string SurName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Country Country { get; set; }
            public Gender Gender { get; set; }
            public Contacts ContactMethod { get; set; }
            public Employ(string name, string surName, DateTime dateOfBirth, Country country, Gender gender, Contacts contactMethod)
            {
                Name = name;
                SurName = surName;
                DateOfBirth = dateOfBirth;
                Country = country;
                Gender = gender;
                ContactMethod = contactMethod;
            }
            public int CalculateAge()
            {
                var today = DateTime.Now;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) age--;
                return age;
            }
            public static void PrintEmployeesFromSameCountry(Employ[] employees, Country country)
            {
                Console.WriteLine($"Employees from {country}");
                foreach (var employee in employees)
                {
                    if (employee.Country == country)
                    {
                        Console.WriteLine($"{employee.Name} {employee.SurName}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}