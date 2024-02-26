using Microsoft.AspNetCore.Mvc;
using Mission08_Team0404.Models;
using System.Diagnostics;

namespace Mission08_Team0404.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }

}
