using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MVC_cours_isitech.Models;


public class Teacher : IdentityUser
{
    // [Required(ErrorMessage = "L'identifiant est obligatoire")]
    // [Display(Name = "Identifiant")]
    // public int Id { get; set; }

    [StringLength(20, MinimumLength = 5)]
    public string Lastname { get; set; }
    public string Firstname { get; set; }


}