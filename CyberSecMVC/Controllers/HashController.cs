using System.Security.Cryptography;
using System.Text;
using CyberSecClassLibrary;
using CyberSecMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CyberSecMVC.Controllers
{
    public class HashController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.result = "";
            return View();
        }

        [HttpPost]
        public IActionResult Hash(HashModel model)
        {
            switch (model.hashType)
            {
                case "SHA512":
                    ViewBag.result = new Hash().SHA512(model.toHash);
                    break;
                case "SHA1":
                    ViewBag.result = new Hash().SHA1(model.toHash);
                    break;
                case "SHA256":
                    ViewBag.result = new Hash().SHA256(model.toHash);
                    break;
                case "MD5":
                    ViewBag.result = new Hash().MD5(model.toHash);
                    break;
                case "BCrypt":
                    ViewBag.result = new Hash()._BCrypt(model.toHash);
                    break;
                default:
                    ViewBag.result = "Invalid hashing algorithm selected.";
                    break;
            }
            return View("Index");
        }
    }
}