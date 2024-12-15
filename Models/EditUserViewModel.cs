using System.ComponentModel.DataAnnotations;

public class EditUserViewModel
{
    public string Id { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public string Firstname { get; set; } = string.Empty;
    
    [Required]
    public string Lastname { get; set; } = string.Empty;
    
    [Required]
    public DateOnly DateOfBirth { get; set; }
    
    public string? Major { get; set; }
    
    public string? Subject { get; set; }
    
    public string Role { get; set; } = string.Empty;
}