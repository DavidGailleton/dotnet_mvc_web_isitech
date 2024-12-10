namespace MVC_cours_isitech.Models;

public interface IPerson
{
    public int? Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    public DateOnly BirthDate { get; set; }
}