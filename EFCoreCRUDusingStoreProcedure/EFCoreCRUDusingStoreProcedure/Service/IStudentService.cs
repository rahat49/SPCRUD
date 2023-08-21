using EFCoreCRUDusingStoreProcedure.Models;

namespace EFCoreCRUDusingStoreProcedure.Service
{
    public interface IStudentService
    {
        List<Student> GetAll(string name);
        void SaveOrUpdate(Student student);
        void Delete(int studentId);
    }
}
