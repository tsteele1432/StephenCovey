using System;
using System.ComponentModel.DataAnnotations;

namespace Covey.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public int Quadrant { get; set; }
        public string Category { get; set; }
        public string Completed { get; set; }

    }
}
