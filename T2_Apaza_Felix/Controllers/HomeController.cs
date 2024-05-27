using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T2_Apaza_Felix.Models;

namespace T2_Apaza_Felix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Distribuidores Peru
        public IActionResult DisPeru()
        {
            return View();
        }

        //Distribuidores Mundo
        public IActionResult DisMundo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
