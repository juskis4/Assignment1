using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Job
    { 
        [Required]
        public string JobTitle { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Please enter a valid salary")]
        public int Salary { get; set; }
    }
}