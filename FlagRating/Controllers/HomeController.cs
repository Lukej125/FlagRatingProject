using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FlagRating.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace FlagRating.Controllers;
public class HomeController : Controller
{
    private MyContext _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet("")]
    public IActionResult LandingPage()
    {
        return View();
    }
    [HttpGet("Login")]
    public IActionResult Login()
    {
        return View();
    }
    [HttpGet("Register")]
    public IActionResult Register()
    {
        return View();
    }

    // [HttpPost("users/create")]
    // public IActionResult CreateUser(User NewUser)
    // {
    //     if (ModelState.IsValid)
    //     {
    //         PasswordHasher<User> Hasher = new PasswordHasher<User>();
    //         NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
    //         _context.Add(NewUser);
    //         _context.SaveChanges();
    //         HttpContext.Session.SetInt32("UserId", NewUser.UserId);
    //         HttpContext.Session.SetString("UserName", NewUser.Username);
    //         return RedirectToAction("Dashboard", "Post");
    //     }
    //     else
    //     {
    //         return View("Register");
    //     }
    // }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
