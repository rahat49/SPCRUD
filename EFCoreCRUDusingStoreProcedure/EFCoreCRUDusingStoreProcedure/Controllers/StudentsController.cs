using EFCoreCRUDusingStoreProcedure.Models;
using EFCoreCRUDusingStoreProcedure.Service;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreCRUDusingStoreProcedure.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService _studentService=null;
        public StudentsController(IStudentService studentService)
        { 
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public List<Student> GetStudents(string name)
        {
            return _studentService.GetAll(name);
        }
        public void SaveOrUpdate(Student student)
        {
            _studentService.SaveOrUpdate(student);
        }
        public void Delete(int studentid)
        {
            _studentService.Delete(studentid);
        }
    }
}
