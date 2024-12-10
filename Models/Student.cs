namespace MVC_cours_isitech.Models;

public class Student : IPerson
{    
    public int PersonId { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public int? Age { get; set; }
    public float? Gpa { get; set; }
    public DateTime? DateOfBirth { get; set; }
}