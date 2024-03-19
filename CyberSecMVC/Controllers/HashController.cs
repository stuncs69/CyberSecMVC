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
        public IActionResult SHA512(HashModel model)
        {
            ViewBag.result = new Hash().SHA512(model.toHash);
            return View("Index");
        }

        [HttpPost]
        public IActionResult SHA1(HashModel model)
        {
            ViewBag.result = new Hash().SHA1(model.toHash);
            return View("Index");
        }

        [HttpPost]
        public IActionResult SHA256(HashModel model)
        {
            ViewBag.result = new Hash().SHA256(model.toHash);
            return View("Index");
        }

        [HttpPost]
        public IActionResult MD5(HashModel model)
        {
            ViewBag.result = new Hash().MD5(model.toHash);
            return View("Index");
        }

        [HttpPost]
        public IActionResult BCrypt(HashModel model)
        {
            ViewBag.result = new Hash()._BCrypt(model.toHash);
            return View("Index");
        }
    }
}