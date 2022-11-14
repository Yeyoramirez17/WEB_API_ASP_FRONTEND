using WEB_API_FRONTEND.Models;

namespace WEB_API_FRONTEND.Interface
{
    public interface InterfaceStudent
    {
        Task<List<Student>> GetAll();
        Task<StudentCourse> GetStudentAndCoursesById(int idStudent);
    }
}


