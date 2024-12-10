using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;

[PrimaryKey("Id")]
public class Student : IPerson
{    
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string? Firstname { get; set; }
    
    [Required]
    public string? Lastname { get; set; }
    public int? Age { get; set; }
    public float? Gpa { get; set; }
    public DateTime? DateOfBirth { get; set; }
}