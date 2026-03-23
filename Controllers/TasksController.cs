using Microsoft.AspNetCore.Mvc;
using Sprint_13_Dy_Sa_Bo.Services;

namespace Sprint_13_Dy_Sa_Bo.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITimeService timeService;
        public TasksController(ITimeService service)
        {
            timeService = service;
        }

        public IActionResult SprintTasks()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            DateTime date = timeService.GetDateTime();
            ViewData["Message1"] = "Hello C# Marathon!";
            ViewData["Message2"] = "Welcome to our project!";

            return View(date);
        }
    }
}
