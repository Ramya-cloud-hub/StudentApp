using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Dtos;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
  
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentsRepo _repository;
        private readonly IMapper _mapper;
        public StudentController(IStudentsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       
      [HttpGet]
      public ActionResult <IEnumerable<StudentReadDto>> GetAllStudents()
        {
           var studentsList = _repository.GetAllStudents();

            return Ok(_mapper.Map<IEnumerable<StudentReadDto>>(studentsList));
        }

      [HttpGet("{id}")]
      public ActionResult <Student> GetStudentById(int id)
        {
           var student = _repository.GetStudentById(id);
           if(student == null)
            {
                return NotFound();
            }
           return Ok(_mapper.Map<StudentReadDto>(student));
        }

      [HttpPost]
      public ActionResult <StudentReadDto> CreateStudent(CreateStudentDto createStudentDto)
        {
            var studentModel =_mapper.Map<Student>(createStudentDto);
            _repository.CreateStudent(studentModel);
            _repository.SaveChanges();
            var studentReadDto = _mapper.Map<StudentReadDto>(studentModel);
            return Ok(studentReadDto);
            
        }
    }
}
