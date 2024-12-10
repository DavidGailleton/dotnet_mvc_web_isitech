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
        
        _context.Teachers.Add(teacher);
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        _context.Teachers.Remove(_context.Teachers.Find(id));
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(Teacher teacher)
    {
        if (ModelState.IsValid)
        {
            _context.Update(teacher);
            _context.SaveChanges();
        }
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Index()
    {
        return View(_context.Teachers.ToList());
    }
}