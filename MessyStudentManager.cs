namespace Roslyn;

public class StudentManager
{
    public string StudentName { get; set; }
    public int Age { get; set; }

    private readonly string SchoolName;

    public StudentManager()
    {
        StudentName = "Sakshi";
        Age = 21;
        SchoolName = "ABC School";
    }

    public void DisplayDetails()
    {
        string message = "Student Details";
        Console.WriteLine(message);
        Console.WriteLine(StudentName);
        Console.WriteLine(Age);
        Console.WriteLine(SchoolName);
    }

    public static int CalculateTotal(int marks1, int marks2)
    {
        int total = marks1 + marks2;
        return total;
    }

    public static void UnusedMethod()
    {
    }
}
