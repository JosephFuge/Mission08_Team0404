using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0404.Models
{
    public class UserTask
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        [Required(ErrorMessage = "Task field is required")]
        public string TaskName { get; set; }
        public string? DueDate { get; set; }
        [Required(ErrorMessage = "Quadrant field is required")]
        public int Quadrant { get; set; }
        public string? Category { get; set; }
        public bool? Completed { get; set; }

    }
}
