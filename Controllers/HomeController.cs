using Microsoft.AspNetCore.Mvc;
using PLACEMENT_2.Models;
using System.Diagnostics;

namespace PLACEMENT_2.Controllers
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

        public IActionResult Department()
        {
            return View();
        }

        public IActionResult ApiDepartment()
        {
            return View();

        }

        public IActionResult AddDepartment()
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
