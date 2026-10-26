using Microsoft.AspNetCore.Mvc;
using ScoopAndServe2.Models; // Allows the controller to access the IceCream model.
using System.Collections.Generic;
namespace ScoopAndServe2.Controllers
{
    public class IceCreamController : Controller
    {
        public IActionResult Index()
        {

            // Creates an empty list that can store multiple IceCream objects.
            List<IceCream> iceCreams = new List<IceCream>();

            // Creates an ice cream object and adds it to the list.
            IceCream first = new IceCream
            {
                Id = 1,
                Name = "Chocolate Dream",
                Price = 100m,
                Category = "Chocolate",
                IsAvailable = true
            };
            iceCreams.Add(first);

            // Creates another ice cream object and adds it to the list.
            IceCream second = new IceCream
            {
                Id = 2,
                Name = "Strawberry Delight",
                Price = 80m,
                Category = "Fruit",
                IsAvailable = true
            };
            iceCreams.Add(second);

            // Creates a third ice cream object and adds it to the list.
            IceCream third = new IceCream
            {
                Id = 3,
                Name = "Classic Vanilla",
                Price = 60m,
                Category = "Classic",
                IsAvailable = true
            };
            iceCreams.Add(third);
            // Passes the list of ice creams to the Index view.
            return View(iceCreams);


            ///NEW ACTION METHOD-to add a new ice cream to the list and display it in the view.
            public IActionResult Create()
        {
            // Opens Views/IceCream/Create.cshtml.
            return View();
        }
    }
    }
}

