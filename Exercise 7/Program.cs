using Exercise.Exercise_7;

class Program
{
    public static void Main() {
    
        Student student = new Student("John", "Doe", 20, 12345, 1);
        Student student2 = new Student("Mary", "Doe", 20, 12346, 1);

        student.DisplayInfo();
        student2.DisplayInfo();
    }
}