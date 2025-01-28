using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers;

public class        HomeController : Controller
{
    private IRepository repository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private string message;
    public HomeController(IRepository repo, IHttpContextAccessor httpContextAccessor) {
        repository = repo;
        _httpContextAccessor = httpContextAccessor;
        var hostname = _httpContextAccessor.HttpContext.Request.Host.Value;
        message = $"Docker - ({hostname})"; 
    }
    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
}