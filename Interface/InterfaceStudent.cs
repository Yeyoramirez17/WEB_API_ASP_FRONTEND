using WEB_API_FRONTEND.Models;

namespace WEB_API_FRONTEND.Interface
{
    public interface InterfaceStudent
    {
        Task<List<Student>> GetAll();
        Task<Student> GetStudentById(int IdStudent);
        Task<StudentCourse> GetStudentAndCoursesById(int idStudent);
        Task<Student> CreateStudent(Student student);
        Task UpdateStudent(int idStudent, Student student);
        Task DeleteStudent(int idStudent);
    }
}


