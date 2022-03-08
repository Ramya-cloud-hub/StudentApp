using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Data
{
    public interface IStudentsRepo
    {
        public IEnumerable<Student> GetAllStudents();
        public Student GetStudentById(int id);
        public void CreateStudent(Student obj);
        public bool SaveChanges();
    }
}
