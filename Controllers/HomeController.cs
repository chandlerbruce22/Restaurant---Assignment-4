using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant___Assignment_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant___Assignment_4.Controllers
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
            List<string> restaurantList = new List<string>();

            // For loop to grab each hardcoded item with in the list. Sets formatting and order for html display
            foreach (Restaurants r in Restaurants.GetRestaurants())
            {
                // If statement to check if the dish has been left empty or null. Assigns the value of "It's tasty" if true
                if (r.Dish == null)
                {
                    r.Dish = "It's all tasty!";
                }
                else
                {

                }
                // Format the output string
                restaurantList.Add(string.Format("#{0}: {1} - Best Dish: {2} - Address: {3} - Phone: {4} - Website: {5}", r.Rank, r.Name, r.Dish, r.Address, r.Phone, r.Website));
            }

            return View(restaurantList);
        }

        // Action for the adding a restaurant page.
        [HttpGet]
        public IActionResult AddRest()
        {
            return View();
        }

        // Post action for the restaurant page. Takes temp storage and passes that data through to a confirmation page.
        [HttpPost]
        public IActionResult AddRest(AddRest appResponse)
        {
            TempStorage.AddApplication(appResponse);

            if (ModelState.IsValid)
            {

                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
        }

        // Action for the list of user inputted restaurants
        public IActionResult RestList()
        {
            return View(TempStorage.Applications);
        }


        public IActionResult Privacy()
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
