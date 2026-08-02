using Microsoft.AspNetCore.Mvc;

namespace ToDoAngular.Server.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
