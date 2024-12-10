using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;

public class TeacherController : Controller
{
    public static List<Teacher> Teachers = new()
    {
        new() { PersonId = 0, Firstname = "Mounir", Lastname = "BENDHAMED", Age = 32, Speciality = Specialities.IT },
        new() { PersonId = 1, Firstname = "David", Lastname = "GAILLETON", Age = 20, Speciality = Specialities.CS }
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
        
        int id = Teachers.Last().PersonId + 1;
        
        Teachers.Add(new Teacher() { PersonId = id, Firstname = firstname, Lastname = lastname.ToUpperInvariant(), Age = age, Speciality = speciality });
     
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        int index = Teachers.FindIndex(teacher => teacher.PersonId == id);
        Teachers.RemoveAt(index);
        
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id, string firstname, string lastname, int age, Specialities speciality)
    {
        int index = Teachers.FindIndex(teacher => teacher.PersonId == id);
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