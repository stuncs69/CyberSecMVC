using CyberSecMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberSecMVC.Controllers;

public class CaesarController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private CyberSecClassLibrary.Caesar _caesar = new CyberSecClassLibrary.Caesar();
    
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Modal = false;
        return View("Caesar");
    }

    [HttpPost]
    public IActionResult CaesarEncipher(CaesarModel model)
    {
        ViewBag.EncipherResult = _caesar.Encipher(model.toCypher, 5);
        ViewBag.Modal = true;
        return View("Caesar");
    }

    [HttpPost]
    public IActionResult CaesarDecipher(CaesarModel model)
    {
        ViewBag.DecipherResult = _caesar.Encipher(model.toCypher, -5);
        ViewBag.Modal = true;
        return View("Caesar");
    }
}