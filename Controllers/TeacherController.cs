using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.data;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class TeacherController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public TeacherController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult Add(Teacher teacher)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        _context.Users.Add(teacher);
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(string id)
    {
        var teacher = _context.Users.Find(id);
        
        _context.Users.Remove(teacher);
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(Teacher teacher)
    {
        if (ModelState.IsValid)
        {
            _context.Users.Update(teacher);
            _context.SaveChanges();
        }
        
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Index()
    {
        return View(_context.Users.ToList());
    }
}