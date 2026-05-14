namespace NewProgram.StudentApp;

public class StudentDepartment
{
    public string? Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public void ShowAllStudents()
    {
        foreach (var student in Students)
            Console.WriteLine(student);
    }
}
