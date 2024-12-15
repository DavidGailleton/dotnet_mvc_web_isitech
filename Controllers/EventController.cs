using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.data;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

[Authorize]
public class EventController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public EventController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index(string searchString, DateTime? searchDate)
    {
        var eventsQuery = _context.Events.AsQueryable();

        if (!string.IsNullOrEmpty(searchString))
        {
            eventsQuery = eventsQuery.Where(e => 
                e.Title.Contains(searchString) || 
                e.Description.Contains(searchString));
        }

        if (searchDate.HasValue)
        {
            var date = searchDate.Value.Date;
            eventsQuery = eventsQuery.Where(e => 
                e.EventDate.Date == date);
        }

        eventsQuery = eventsQuery.OrderByDescending(e => e.EventDate);
        var events = await eventsQuery.ToListAsync();

        // Stocker les valeurs de recherche dans ViewData
        ViewData["CurrentSearch"] = searchString;
        ViewData["CurrentDate"] = searchDate?.ToString("yyyy-MM-dd");

        return View(events);
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Event @event)
    {
        _context.Events.Add(@event);
        
        _context.SaveChanges();
        
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var @event = _context.Events.Find(id);
        
        return View(@event);
    }
    
    [HttpPost]
    public IActionResult Edit(Event @event)
    {
        _context.Events.Update(@event);
        
        _context.SaveChanges();
        
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var @event = _context.Events.Find(id);
        
        _context.Events.Remove(@event);
        
        _context.SaveChanges();
        
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        var @event = _context.Events.Find(id);
        
        return View(@event);
    }
}