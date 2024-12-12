using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TP_ESPNET_B3.Data;
using TP_ESPNET_B3.Models;

namespace TP_ESPNET_B3.Controllers;

[Authorize]
public class EventController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public EventController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var events = _context.Events.ToList();
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