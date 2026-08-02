using Microsoft.AspNetCore.Mvc;

namespace ToDoAngular.Server.Controllers
{
    public class ToDoTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
