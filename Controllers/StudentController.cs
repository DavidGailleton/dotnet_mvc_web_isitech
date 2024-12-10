using Microsoft.AspNetCore.Mvc;
using MVC_cours_isitech.data;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class StudentController : Controller
{
    private static readonly ApplicationDbContext _context;
    
    public Student[] Students = _context.Students.ToArray();
    
    public ActionResult Add(Student student)
    {
        _context.Add(student);
        
        _context.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }
    
    public ActionResult Index()
    {
        return View(Students);
    }
}