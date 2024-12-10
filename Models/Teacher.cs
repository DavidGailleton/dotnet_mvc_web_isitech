using System.ComponentModel.DataAnnotations;

namespace MVC_cours_isitech.Models;

public enum Specialities
{
    IT = 0, CS = 1, Other = 3
}

public class Teacher : IPerson  
{
    [Required]
    public int PersonId { get; set; }
    
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