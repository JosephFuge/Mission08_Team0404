using Microsoft.AspNetCore.Mvc;
using Mission08_Team0404.Models;
using System.Diagnostics;

namespace Mission08_Team0404.Controllers
{
    public class HomeController : Controller
    {
        private IUserTaskRepository _repo;

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateTask() { 
            return View("CreateEditTask"); 
        }

        [HttpPost]
        public IActionResult CreateTask(UserTask task) {
            return View("CreateEditTask");
        }

        [HttpGet]
        public IActionResult EditTask(int taskId)
        {
            UserTask userTask = _repo.UserTasks.FirstOrDefault(x => x.UserTaskId == taskId);

            return View("CreateEditTask", userTask);
        }

        [HttpPost]
        public IActionResult EditTask(UserTask task) {

            if (ModelState.IsValid)
            {
                _repo.AddUserTask(task);
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
            UserTask userTask = _repo.UserTasks.FirstOrDefault(x => x.UserTaskId == taskId);

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
