using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    
    public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }
    
    [HttpGet]
    [AllowAnonymous]
    public IActionResult RegisterStudent()
    {
        return View();
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterStudent(RegisterStudentViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var student = new Student()
        {
            UserName = model.Email,
            Email = model.Email,
            Firstname = model.Firstname,
            Lastname = model.Lastname,
            DateOfBirth = model.Birthdate,
            Major = model.Major
        };
        
        var result = await _userManager.CreateAsync(student, model.Password);
        
        if (result.Succeeded)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            var role = await _roleManager.FindByNameAsync("Student");
        
            if (role == null)
            {
                ModelState.AddModelError(string.Empty, "Role configuration error.");
                return View(model);
            }
        
            var roleResult = await _userManager.AddToRoleAsync(user, role.Name);
            if (!roleResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Failed to assign role.");
                return View(model);
            }
        
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");        }
        
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        
        return View(model);
    }
    
    [HttpGet]
    [AllowAnonymous]
    public IActionResult RegisterTeacher()
    {
        return View();
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterTeacher(RegisterTeacherViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var teacher = new Teacher()
        {
            UserName = model.Email,
            Email = model.Email,
            Firstname = model.Firstname,
            Lastname = model.Lastname,
            DateOfBirth = model.Birthdate,
            Subject = model.Subject
        };
        
        var result = await _userManager.CreateAsync(teacher, model.Password);
        
        if (result.Succeeded)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            var role = await _roleManager.FindByNameAsync("Teacher");
        
            if (role == null)
            {
                ModelState.AddModelError(string.Empty, "Role configuration error.");
                return View(model);
            }
        
            var roleResult = await _userManager.AddToRoleAsync(user, role.Name);
            if (!roleResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Failed to assign role.");
                return View(model);
            }
        
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");        }
        
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        
        return View(model);
    }
    
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.StayConnected, false);
        
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        
        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        
        return View();
    }
    
    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        
        return RedirectToAction("Login", "Account");
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin,Teacher" )]
    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users
            .ToListAsync();

        var userRoles = new Dictionary<string, string>();
        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            userRoles[user.Id] = roles.FirstOrDefault() ?? "";
        }

        ViewBag.UserRoles = userRoles;
    
        return View(users);
    }

    [Authorize(Roles = "Admin,Teacher")]
    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        var model = new EditUserViewModel
        {
            Id = user.Id,
            Email = user.Email,
            Firstname = user.Firstname,
            Lastname = user.Lastname,
            DateOfBirth = user.DateOfBirth
        };

        // Si c'est un étudiant
        if (user is Student student)
        {
            model.Major = student.Major;
            model.Role = "Student";
        }
        // Si c'est un professeur
        else if (user is Teacher teacher)
        {
            model.Subject = teacher.Subject;
            model.Role = "Teacher";
        }

        return View(model);
    }
    

    [Authorize(Roles = "Admin,Teacher")]
    [HttpPost]
    public async Task<IActionResult> Edit(EditUserViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _userManager.FindByIdAsync(model.Id);
        if (user == null)
        {
            return NotFound();
        }

        user.Email = model.Email;
        user.Firstname = model.Firstname;
        user.Lastname = model.Lastname;
        user.DateOfBirth = model.DateOfBirth;

        if (user is Student student && !string.IsNullOrEmpty(model.Major))
        {
            student.Major = model.Major;
        }
        else if (user is Teacher teacher && !string.IsNullOrEmpty(model.Subject))
        {
            teacher.Subject = model.Subject;
        }

        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            TempData["SuccessMessage"] = "User updated successfully";
            return RedirectToAction(nameof(Index));
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(model);
    }
    
    [Authorize(Roles = "Admin,Teacher")]
    [HttpPost]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            TempData["ErrorMessage"] = "User not found.";
            return RedirectToAction(nameof(Index));
        }

        if (User.IsInRole("Teacher"))
        {
            var userRoles = await _userManager.GetRolesAsync(user);
            if (userRoles.Contains("Teacher") || userRoles.Contains("Admin"))
            {
                TempData["ErrorMessage"] = "You are not authorized to delete this user.";
                return RedirectToAction(nameof(Index));
            }
        }

        try
        {
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "User successfully deleted.";
            }
            else
            {
                TempData["ErrorMessage"] = "Error deleting user: " + string.Join(", ", result.Errors.Select(e => e.Description));
            }
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = "An error occurred while deleting the user.";
        }

        return RedirectToAction(nameof(Index));
    }
    
}