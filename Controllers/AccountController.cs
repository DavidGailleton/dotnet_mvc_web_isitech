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
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Index()
    {
        var accounts = await _userManager.Users.ToListAsync();
        return View(accounts);
    }
    
}