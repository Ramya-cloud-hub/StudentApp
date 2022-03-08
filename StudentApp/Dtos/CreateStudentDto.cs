using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Dtos
{
    public class CreateStudentDto
    {
        [Required]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [Required]
        public string StudentEmailId { get; set; }

        [Required]
        public string StudentMobileNumber { get; set; }
    }
}
