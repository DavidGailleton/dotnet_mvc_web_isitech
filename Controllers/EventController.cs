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
    
    private readonly int PageSize = 5;
    
    [HttpGet]
    public async Task<IActionResult> Index(string sortOrder, string searchString, 
        DateTime? searchDate, int? page)
    {
        var viewModel = new EventsViewModel();
        
        viewModel.CurrentSort = sortOrder;
        viewModel.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
        viewModel.DateSortParam = sortOrder == "date" ? "date_desc" : "date";
        
        if (searchString != null || searchDate != null)
            page = 1;
        else
        {
            searchString = viewModel.CurrentFilter;
            searchDate = viewModel.CurrentDateFilter;
        }
        
        viewModel.CurrentFilter = searchString;
        viewModel.CurrentDateFilter = searchDate;

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
            eventsQuery = eventsQuery.Where(e => e.EventDate.Date == date);
        }

        // Appliquer le tri
        switch (sortOrder)
        {
            case "title_desc":
                eventsQuery = eventsQuery.OrderByDescending(e => e.Title);
                break;
            case "date":
                eventsQuery = eventsQuery.OrderBy(e => e.EventDate);
                break;
            case "date_desc":
                eventsQuery = eventsQuery.OrderByDescending(e => e.EventDate);
                break;
            default:
                eventsQuery = eventsQuery.OrderBy(e => e.Title);
                break;
        }

        // Pagination
        int pageNumber = (page ?? 1);
        var totalItems = await eventsQuery.CountAsync();
        viewModel.TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);
        viewModel.CurrentPage = pageNumber;

        viewModel.Events = await eventsQuery
            .Skip((pageNumber - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();

        return View(viewModel);
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