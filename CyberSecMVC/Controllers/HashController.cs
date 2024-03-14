using System.Security.Cryptography;
using System.Text;
using CyberSecMVC.Models;
using Microsoft.AspNetCore.Mvc;

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
        byte[] hashBytes = new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes(model.toHash));
        
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("x2"));
        }
        string hashResult = sb.ToString();
        
        ViewBag.result = hashResult;
        
        return View();
    }
}