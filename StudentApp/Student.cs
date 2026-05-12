namespace NewProgram.StudentApp;

public class Student
{
    public string RegNo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    
    override public string ToString() => $"Reg NO: {RegNo}, {FirstName} {LastName}";
}
