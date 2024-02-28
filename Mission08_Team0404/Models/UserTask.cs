using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? CategoryName { get; set; }
        public bool? Completed { get; set; }

    }
}
