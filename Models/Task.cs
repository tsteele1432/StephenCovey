using System;
using System.ComponentModel.DataAnnotations;

namespace Covey.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public int Quadrant { get; set; }
        public string Category { get; set; }
        public string Completed { get; set; }

    }
}
