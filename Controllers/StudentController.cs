using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers;

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