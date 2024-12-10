using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;


[PrimaryKey("Id")]
public class Teacher : IPerson  
{
    
    public int? Id { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string? Firstname { get; set; }
    
    [Required]
    [MaxLength(20)]
    public string? Lastname { get; set; }
    
    [Required]
    public DateOnly BirthDate { get; set; }
    
    [Required]
    public Specialities Speciality { get; set; }
}