using EFCoreCRUDusingStoreProcedure.Data;
using EFCoreCRUDusingStoreProcedure.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUDusingStoreProcedure.Service
{
    public class StudentService : IStudentService
    {

        StudentDbContext _context=null;
        public StudentService(StudentDbContext context)
        {
            _context = context;
        }
        public void Delete(int studentId)
        {
            _context.Database.ExecuteSqlRaw($"PRO_DELETE_STUDENT {studentId}");
            var students = _context.Students.ToList();
        }

        public List<Student> GetAll(string name)
        {
            var student = _context.Students.FromSqlRaw($"PRO_GET_STUDENTS {name}").ToList();
            return student;
        }

        public void SaveOrUpdate(Student student)
        {
            _context.Database.ExecuteSqlRaw($"PRO_SAVEORUPDATE_STUDENT {student.StudentID},{student.Name},{student.Age}");
            var students = _context.Students.ToList();
        }
    }
}
