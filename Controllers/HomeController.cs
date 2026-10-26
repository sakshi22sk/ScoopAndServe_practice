
using Microsoft.AspNetCore.Mvc; // Provides Controller, IActionResult, View(), and MVC features.
using ScoopAndServe2.Models; // Allows this controller to use ErrorViewModel.
using System.Diagnostics; // Provides Activity, which can contain diagnostic trace information.

namespace ScoopAndServe2.Controllers // Organizes this class in the Controllers namespace.
{
    public class HomeController : Controller // Defines a controller; inherits MVC functionality from Controller.
    {
        // Stores a logger that can record information and errors for this controller.
        private readonly ILogger<HomeController> _logger;

        // Constructor: ASP.NET Core supplies the logger through dependency injection.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Saves the logger so other methods can use it.
        }

        // Handles requests mapped to the Index action, usually the Home page.
        public IActionResult Index()
        {
            return View(); // Returns Views/Home/Index.cshtml without passing a model.
        }

        // Handles requests mapped to the Privacy action.
        public IActionResult Privacy()
        {
            return View(); // Returns Views/Home/Privacy.cshtml.
        }

        // Prevents the error response from being cached by the browser or intermediary caches.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Action responsible for returning the error page.
        {
            // Creates the model and chooses an available request identifier.
            return View(new ErrorViewModel
            {
                // Prefer the current diagnostic Activity ID; otherwise use the HTTP request trace ID.
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
            // Passes the populated model to Views/Home/Error.cshtml.
        }
    }
}
