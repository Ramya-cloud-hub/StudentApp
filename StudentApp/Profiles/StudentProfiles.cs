using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StudentApp.Dtos;

namespace StudentApp.Profiles
{
    public class StudentProfiles : Profile
    {
       public StudentProfiles()
        {
            CreateMap<Student, StudentReadDto>();
            CreateMap<CreateStudentDto, Student>();
        }
    }
}
