using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sprint_13_Dy_Sa_Bo.Models;
using Sprint_13_Dy_Sa_Bo.Services;

namespace Sprint_13_Dy_Sa_Bo.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult ProductInfo()
        {
            return View();
        }

        public IActionResult ShoppingList()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "Milk", 2 },
                { "Bread", 2 },
                { "Cake", 1 },
                { "IceCream", 5 },
                { "Cola", 10 }
            };

            return View(dictionary);
        }

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            List<string> supermarkets = new List<string> { "WellMart", "Silpo", "ATB" };
            ViewBag.Supermarkets = new SelectList(supermarkets);

            List<DateTime> dates = new List<DateTime>
            {
                DateTime.Today,
                DateTime.Today.AddDays(1),
                DateTime.Today.AddDays(2)
            };
            ViewBag.Dates = dates;

            Dictionary<string, int> products = new Dictionary<string, int>
            {
                { "Bread", 10 },
                { "Milk", 11 },
                { "Cheese", 140 },
                { "Sausage", 110 },
                { "Potato", 7},
                { "Banana", 23 },
                { "Tomato", 25 },
                { "Candy", 75 }
            };

            ViewBag.Products = new MultiSelectList(products.Keys);

            return View();
        }

        [HttpPost]
        public IActionResult ShoppingCart(string fullName, string address)
        {
            if (fullName == null || address == null)
            {
                ViewBag.Message = $"enter correct data!!!!!!!";
                return View();
            }

            ViewBag.Message = $"Your products will be shipped at: {address}.Bon appetite, {fullName}!";

            return View();
        }
    }
}
