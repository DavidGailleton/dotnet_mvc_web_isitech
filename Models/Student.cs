using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;

[PrimaryKey("Id")]
public class Student : IPerson
{    
    
    public int? Id { get; set; }
    
    [Required]
    public string Firstname { get; set; }
    
    [Required]
    public string? Lastname { get; set; }
    
    [Required]
    public DateOnly BirthDate { get; set; }
}