using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class Student
    {
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Too long name!")]
        public string Name { get; set; }
        
        public string City { get; set; }
        
        [Required]
        [Range(1, 120)]
        public int Age { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthYear { get; set; }
    }
}
