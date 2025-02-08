using Microsoft.AspNetCore.Mvc;
using Mission5Assignment.Models;
using System.Diagnostics; // Add this to use the Activity class

namespace Mission5Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action for the home page
        public IActionResult Index()
        {
            return View();
        }

        // Action for the privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action for the calculator page
        public IActionResult Calculator()
        {
            return View();
        }

        // Error action to handle exceptions
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Use HttpContext.TraceIdentifier directly to avoid the Activity issue
            return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
        }
    }
}