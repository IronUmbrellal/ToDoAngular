using Microsoft.AspNetCore.Mvc;

namespace ToDoAngular.Server.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
