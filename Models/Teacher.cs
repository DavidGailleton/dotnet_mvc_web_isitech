using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;

public enum Specialities
{
    IT = 0, CS = 1, Other = 3
}

[PrimaryKey("Id")]
public class Teacher : IPerson  
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string? Firstname { get; set; }
    [Required]
    [MaxLength(20)]
    public string? Lastname { get; set; }
    
    [Required]
    public int? Age { get; set; }
    
    [Required]
    public Specialities Speciality { get; set; }
}