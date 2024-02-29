using SQLitePCL;

namespace Mission08_Team0404.Models
{
    public interface ITaskRepository
    {
        List<UserTask> UserTasks { get; }
        public void AddTask(UserTask UserTask);
        public void EditTask(int TaskId);
        public void DeleteTask(int TaskId);
        public void UpdateTask(UserTask UserTask);

        List<Category> Categories { get; }
    }
}