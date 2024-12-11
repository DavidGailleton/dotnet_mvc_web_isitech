using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MVC_cours_isitech.Models;

namespace MVC_cours_isitech.Controllers;

public class AccountController : Controller
{
    private readonly SignInManager<Teacher> _signInManager;

    private readonly UserManager<Teacher> _userManager;

    public AccountController(SignInManager<Teacher> signInManager, UserManager<Teacher> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Register(AccountViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = new Teacher
        {
            UserName = model.Email,
            Email = model.Email,
            Firstname = model.Firstname,
            Lastname = model.Lastname,
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            await _signInManager.SignInAsync(user, isPersistent: false);
            return RedirectToAction("Index", "Home");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return Redirect($"/home/Error/");
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(AccountViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View(model);
    }
}