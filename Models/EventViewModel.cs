namespace MVC_cours_isitech.Models;

public class EventsViewModel
{
    public List<Event> Events { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public string CurrentSort { get; set; }
    public string TitleSortParam { get; set; }
    public string DateSortParam { get; set; }
    public string CurrentFilter { get; set; }
    public DateTime? CurrentDateFilter { get; set; }
}