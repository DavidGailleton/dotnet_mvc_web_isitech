using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_cours_isitech.data;
using MVC_cours_isitech.Models;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var upcomingEvents = _context.Events
            .Where(e => e.EventDate > DateTime.Now)
            .OrderBy(e => e.EventDate)
            .Take(6)
            .ToList();
            
        return View(upcomingEvents);
    }
    // ... autres actions
}