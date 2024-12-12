using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TP_ESPNET_B3.Models;

public class User : IdentityUser
{
    [StringLength(20, MinimumLength = 5)]
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateOnly DateOfBirth { get; set; }
}