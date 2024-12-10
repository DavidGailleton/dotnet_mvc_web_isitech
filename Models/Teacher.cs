using Microsoft.AspNetCore.Mvc;

namespace mvc.Models;

public enum Specialities
{
    IT, CS, Other
}

public class Teacher : IPerson
{
    public int PersonId { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public int? Age { get; set; }
    public Specialities? Speciality { get; set; }
}