using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ToDoDBContext _context;

        public HomeController(ILogger<HomeController> logger,ToDoDBContext context)
        {
            _logger = logger;
            _context= context;
        }

        public IActionResult Index()
        {
            var allTasks = _context.Tasks.ToList();
            return View(allTasks);
        }
        [HttpPost]
        public IActionResult AddTask(int id, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return BadRequest("Task title cannot be empty.");
            }
            if (id == 0) // Create new task
            {
                _context.Tasks.Add(new Models.Task { Value = title });
            }
            else // Edit existing task
            {
                var existingTask = _context.Tasks.Find(id);
                if (existingTask != null)
                {
                    existingTask.Value = title;
                    _context.Tasks.Update(existingTask);
                }
                else
                {
                    return NotFound("Task not found.");
                }
            }

            _context.SaveChanges(true);
            return RedirectToAction("Index");
        }




        public IActionResult Delete(int id)
        {
            var taskInDB = _context.Tasks.SingleOrDefault(x => x.Id == id);
            if (taskInDB == null)
            {
                return NotFound("Task not found.");
            }

            _context.Tasks.Remove(taskInDB);
            _context.SaveChanges(true);
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
