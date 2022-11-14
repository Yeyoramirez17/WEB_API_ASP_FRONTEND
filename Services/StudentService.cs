using WEB_API_FRONTEND.Models;
using WEB_API_FRONTEND.Interface;

namespace WEB_API_FRONTEND.Services
{
    public class StudentService : InterfaceStudent
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient _httpClient) {
            httpClient = _httpClient;
        }
        public async Task<List<Student>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Student>>("api/Students/GetAll");
        }

        public async Task<StudentCourse> GetStudentAndCoursesById(int idStudent){
            return await httpClient.GetFromJsonAsync<StudentCourse>($"api/Students/StudentAndCourses/{idStudent}");
        }
    }
}