namespace NewProgram.StudentApp;

public class StudentDepartment
{
    public string? Name { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public void ShowAllStudents(CancellationToken token = default)
    {
        
            foreach (var student in Students)
            { 
                Thread.Sleep(1000);
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }
                Console.WriteLine(student);
            }
        
    }
}
