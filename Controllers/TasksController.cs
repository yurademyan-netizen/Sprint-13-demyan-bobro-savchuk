using Microsoft.AspNetCore.Mvc;
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
    }
}
