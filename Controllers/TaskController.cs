using Microsoft.AspNetCore.Mvc;

namespace Sprint_13_Dy_Sa_Bo.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }
    }
}
