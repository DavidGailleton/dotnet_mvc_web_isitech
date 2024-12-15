namespace MVC_cours_isitech.Models;

public class RegisterStudentViewModel
{
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public string ConfirmedPassword { get; set; }
    
    public string Firstname { get; set; }
    
    public string Lastname { get; set; }
    
    public DateOnly Birthdate { get; set; }
    
    public string? Major { get; set; }
}