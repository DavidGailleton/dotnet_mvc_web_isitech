using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.data;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult Add(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        _context.Students.Add(student);
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
        var student = _context.Students.Find(id);
        
        _context.Students.Remove(student);
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Update(student);
            _context.SaveChanges();
        }
        
        return RedirectToAction(nameof(Index));
    }
    
    public ActionResult Index()
    {
        return View();
    }
}