using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0404.Models;
using System.Diagnostics;

namespace Mission08_Team0404.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;

        public HomeController(ITaskRepository tempRepo)
        {
            _repo = tempRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTask() {
            ViewBag.Categories = _repo.Categories.OrderBy(cat => cat.CategoryId).ToList();
            return View("CreateEditTask"); 
        }

        [HttpPost]
        public IActionResult CreateTask(UserTask task) {
            ViewBag.Categories = _repo.Categories.OrderBy(cat => cat.CategoryId).ToList();

            if (ModelState.IsValid)
            {
                _repo.AddTask(task);
            }

            return View("CreateEditTask");
        }

        [HttpGet]
        public IActionResult EditTask(int taskId)
        {
            ViewBag.Categories = _repo.Categories.OrderBy(cat => cat.CategoryId).ToList();
            UserTask userTask = _repo.UserTasks.FirstOrDefault(x => x.TaskId == taskId);

            return View("CreateEditTask", userTask);
        }

        [HttpPost]
        public IActionResult EditTask(UserTask task) {

            if (ModelState.IsValid)
            {
                _repo.UpdateTask(task);
            }

            var userTaskList = _repo.UserTasks.ToList();

            return View("TaskQuadrants", userTaskList);
        }

        public IActionResult TaskQuadrants()
        {
            var userTaskList = _repo.UserTasks.ToList();

            return View(userTaskList);
        }

        [HttpGet]
        public IActionResult DeleteTask(int taskId)
        {
            UserTask userTask = _repo.UserTasks.FirstOrDefault(x => x.TaskId == taskId);

            return View(userTask);
        }

        [HttpPost]
        public IActionResult DeleteTask(UserTask userTask)
        {
            _repo.DeleteTask(userTask);

            return RedirectToAction("TaskQuadrants");
        }
    }

}
