using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Data
{
    public class StudentsRepo : IStudentsRepo
    {
        private readonly StudentsDbContext _context;
        public StudentsRepo(StudentsDbContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student obj)
        {
            if(obj == null)
            {
                throw new ArgumentNullException();
            }
            _context.Students.Add(obj);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            var student = _context.Students.Find(id);

            return student;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
