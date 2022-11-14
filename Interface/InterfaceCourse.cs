using WEB_API_FRONTEND.Models;
using WEB_API_FRONTEND.Models.ModelsSuport;

namespace WEB_API_FRONTEND.Interface 
{
    public interface InterfaceCourse
    {
        Task <List<Course>> GetAll();
        Task <Course> GetById(int idCourse);
        Task <CourseCreateUpdate> CourseGetById(int idCourse);
        Task <Course> GetCourseAndFaculty(int idCourse);
        Task <CourseCreateUpdate> CreateCourse(CourseCreateUpdate course);
        Task UpdateCourse(int idCourse, CourseCreateUpdate course);
        Task DeleteCourse(int idCourse);
    }
}