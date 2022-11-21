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
        public async Task<Student> GetStudentById(int idStudent) {
            return await httpClient.GetFromJsonAsync<Student>($"api/Students/StudentById/{idStudent}");
        }
        public async Task<StudentCourse> GetStudentAndCoursesById(int idStudent){
            return await httpClient.GetFromJsonAsync<StudentCourse>($"api/Students/StudentAndCourses/{idStudent}");
        }
        public async Task<Student> CreateStudent(Student student) {
            var result = await httpClient.PostAsJsonAsync<Student>("api/Students/CreateStudent", student);
            var newStudent = await result.Content.ReadFromJsonAsync<Student>();
            return newStudent;
        }
        public async Task UpdateStudent(int idStudent, Student student){
            await httpClient.PutAsJsonAsync<Student>($"api/Students/UpdateStudent/{idStudent}", student);
        }
        public async Task DeleteStudent(int idStudent){
            await httpClient.DeleteAsync($"api/Students/DeleteStudent/{idStudent}");
        }
    }
}