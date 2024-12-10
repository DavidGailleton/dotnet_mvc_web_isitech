using Microsoft.AspNetCore.Mvc;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class TeacherController : Controller
{
    public static List<Teacher> Teachers = new()
    {
        new() { Id = 0, Firstname = "Mounir", Lastname = "BENDHAMED", Age = 32, Speciality = Specialities.IT },
        new() { Id = 1, Firstname = "David", Lastname = "GAILLETON", Age = 20, Speciality = Specialities.CS }
    };

    [HttpGet]
    public ActionResult Add()
    {
        return View(Teachers);
    }
    
    [HttpPost]
    public ActionResult Add(string firstname, string lastname, int age, Specialities speciality)
    {
        if (!ModelState.IsValid)
        {
            return View(Teachers);
        }
        
        int id = Teachers.Last().Id + 1;
        
        Teachers.Add(new Teacher() { Id = id, Firstname = firstname, Lastname = lastname.ToUpperInvariant(), Age = age, Speciality = speciality });
     
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        int index = Teachers.FindIndex(teacher => teacher.Id == id);
        Teachers.RemoveAt(index);
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id, string firstname, string lastname, int age, Specialities speciality)
    {
        int index = Teachers.FindIndex(teacher => teacher.Id == id);
        Teachers[index].Firstname = firstname;
        Teachers[index].Lastname = lastname;
        Teachers[index].Age = age;
        Teachers[index].Speciality = speciality;
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Index()
    {
        return View(Teachers);
    }
}