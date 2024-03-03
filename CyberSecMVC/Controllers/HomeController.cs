using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CyberSecMVC.Models;

namespace CyberSecMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private Functions.Caesar _caesar = new Functions.Caesar();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Caesar()
    {
        ViewBag.Modal = false;
        return View();
    }

    [HttpPost]
    public IActionResult CaesarEncipher(Caesar model)
    {
        ViewBag.EncipherResult = _caesar.Encipher(model.toCypher, 5);
        ViewBag.Modal = true;
        return View("Caesar");
    }

    [HttpPost]
    public IActionResult CaesarDecipher(Caesar model)
    {
        ViewBag.DecipherResult = _caesar.Encipher(model.toCypher, -5);
        ViewBag.Modal = true;
        return View("Caesar");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}