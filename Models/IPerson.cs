namespace MVC_cours_isitech.Models;

public interface IPerson
{
    public int PersonId { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public int? Age { get; set; }
}