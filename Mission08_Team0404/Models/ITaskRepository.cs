using SQLitePCL;

namespace Mission08_Team0404.Models
{
    public interface ITaskRepository
    {
        List<UserTask> UserTasks { get; }
        public void AddTask(UserTask UserTask);
    }
}