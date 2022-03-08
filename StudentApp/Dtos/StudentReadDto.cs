using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Dtos
{
    public class StudentReadDto
    {
        public int StudentId { get; set; }
        public string StudentNmae { get; set; }

        public string StudentEmailId { get; set; }

        public string StudentMobileNumber { get; set; }
    }
}
