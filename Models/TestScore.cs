using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;

[PrimaryKey("Id")]
public class TestScore
{
    [Required]
    public int? Id { get; set; }
    
    [Required]
    public Specialities Speciality { get; set; }
    
    [Required]
    public int Score { get; set; }
    
    [Required]
    public Student Student { get; set; }
    
    [Required]
    public Teacher Teacher { get; set; }
}