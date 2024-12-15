using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MVC_cours_isitech.Models;

public class User : IdentityUser
{
    [StringLength(20, MinimumLength = 5)]
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateOnly DateOfBirth { get; set; }
}