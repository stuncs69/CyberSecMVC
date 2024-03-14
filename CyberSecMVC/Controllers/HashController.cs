using System.Security.Cryptography;
using System.Text;
using CyberSecMVC.Models;
using Microsoft.AspNetCore.Mvc;
using SHA512 = CyberSecClassLibrary.SHA512;

namespace CyberSecMVC.Controllers;

public class HashController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.result = "";
        return View();
    }

    [HttpPost]
    public IActionResult Index(HashModel model)
    { 
        ViewBag.result = new SHA512().Hash(model.toHash);
        
        return View();
    }
}