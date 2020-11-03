using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4.Models
{
    public class AddStudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        public string FullName { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 7)]
        public string Group { get; set; }
    }
}
