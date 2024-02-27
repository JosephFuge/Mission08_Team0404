using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0404.Models
{
    public class UserTaskContext : DbContext
    {
        public UserTaskContext(DbContextOptions<UserTaskContext>options) : base(options) 
        { 
        }

        public DbSet<UserTask> UserTasks { get; set; }
    }
}
