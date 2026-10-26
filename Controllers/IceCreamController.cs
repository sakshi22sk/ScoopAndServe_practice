using Microsoft.AspNetCore.Mvc;
using ScoopAndServe2.Models;

namespace ScoopAndServe2.Controllers
{
    public class IceCreamController : Controller
    {
        // Displays the ice cream menu.
        public IActionResult Index()
        {
            return View();
        }

        // Displays the Add Ice Cream form.
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Receives submitted form data.
        [HttpPost]
        public IActionResult Create(IceCream model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Saving will be implemented next.
            return RedirectToAction("Index");
        }
    }
}