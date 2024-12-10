using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;

[PrimaryKey("PersonId")]
public class Student : IPerson
{    
    [Required]
    public int PersonId { get; set; }
    
    [Required]
    public string? Firstname { get; set; }
    
    [Required]
    public string? Lastname { get; set; }
    public int? Age { get; set; }
    public float? Gpa { get; set; }
    public DateTime? DateOfBirth { get; set; }
}