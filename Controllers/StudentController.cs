using Microsoft.AspNetCore.Mvc;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class StudentController : Controller
{
    private static List<Student> students = new()
    {
        new() {PersonId = 0, Firstname = "John", Lastname = "Doe"},
        new() {PersonId = 0, Firstname = "John", Lastname = "Doe"},
        new() {PersonId = 0, Firstname = "John", Lastname = "Doe"},
        new() {PersonId = 0, Firstname = "John", Lastname = "Doe"},
    };

    public static void AddStudent(string Firstname, string Lastname, int Age)
    {
        students.Add(new() {Firstname = Firstname, Lastname = Lastname, Age = Age});
    }
    
    public ActionResult Index()
    {
        return View(students);
    }
}