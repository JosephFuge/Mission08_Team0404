﻿
namespace Mission08_Team0404.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private UserTaskContext _context;

        public EFTaskRepository(UserTaskContext temp) {
            _context = temp;
        }

        public List<UserTask> UserTasks => _context.UserTasks.ToList();

        public void AddTask(UserTask UserTask)
        {
            _context.Add(UserTask);
            _context.SaveChanges();
        }

        public void EditTask(int TaskId)
        {
            _context.Update(TaskId);
            _context.SaveChanges();
        }

        public void DeleteTask(int TaskId)
        {
            _context.Remove(TaskId);
            _context.SaveChanges();
        }
    }
}
