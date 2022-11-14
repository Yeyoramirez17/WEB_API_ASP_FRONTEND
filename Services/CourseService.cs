using WEB_API_FRONTEND.Models;
using WEB_API_FRONTEND.Models.ModelsSuport;
using WEB_API_FRONTEND.Interface;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace WEB_API_FRONTEND.Services
{
    public class CourseService : InterfaceCourse
    {
        private readonly HttpClient _httpClient;
        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        }
        public async Task<CourseCreateUpdate> CreateCourse(CourseCreateUpdate course)
        {
            var result = await _httpClient.PostAsJsonAsync<CourseCreateUpdate>("api/Courses/CreateCourse", course);
            var newCourse = await result.Content.ReadFromJsonAsync<CourseCreateUpdate>();
            return newCourse;
        }
        public async Task DeleteCourse(int idCourse)
        {
            await _httpClient.DeleteAsync($"api/Courses/DeleteCourse/{idCourse}");
        }
        public async Task<List<Course>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Course>>("api/Courses");
        }

        public async Task<Course> GetById(int idCourse)
        {
            return await _httpClient.GetFromJsonAsync<Course>($"api/Courses/GetById/{idCourse}");
        }
        public async Task<CourseCreateUpdate> CourseGetById(int idCourse)
        {
            return await _httpClient.GetFromJsonAsync<CourseCreateUpdate>($"api/Courses/CourseGetById/{idCourse}");
        }
        public Task<Course> GetCourseAndFaculty(int idCourse)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCourse(int idCourse, CourseCreateUpdate course)
        {
            await _httpClient.PutAsJsonAsync<CourseCreateUpdate>($"api/Courses/UpdateCourse/{idCourse}", course);
        }
    }
}