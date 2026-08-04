using Microsoft.AspNetCore.Mvc;
using ToDoAngular.Server.DataAccess;

namespace ToDoAngular.Server.Controllers
{
    [ApiController]
    [Route("api/[todotasks]")]
    public class ToDoTaskController : ControllerBase
    {
        private readonly TaskRepository _task;

        public ToDoTaskController(TaskRepository task) { _task = task; }


    }
}
