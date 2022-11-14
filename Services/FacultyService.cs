using WEB_API_FRONTEND.Models;
using WEB_API_FRONTEND.Interface;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace WEB_API_FRONTEND.Services
{
    public class FacultyService : InterfaceFaculty
    {
        private readonly HttpClient httpClient;
        public FacultyService(HttpClient _httpClient)
        {
            httpClient = _httpClient;
            ServicePointManager.ServerCertificateValidationCallback =  delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) 
            { return true; };
        }
        public async Task<Faculty> CreateFaculty(Faculty faculty)
        {
            var result = await httpClient.PostAsJsonAsync<Faculty>("api/Faculties/CreateFaculty", faculty);
            var newFaculty = await result.Content.ReadFromJsonAsync<Faculty>();
            return newFaculty;
        }

        public async Task DeleteFaculty(int idFaculty)
        {
            await httpClient.DeleteAsync($"api/Faculties/DeleteFaculty/{idFaculty}");
        }
        public async Task<List<Faculty>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Faculty>>("api/Faculties");
        }
        public async Task<Faculty> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Faculty>($"api/Faculties/{id}");
        }
        public async Task<Faculty> GetByNameFaculty(string nameFaculty) 
        {
            return await httpClient.GetFromJsonAsync<Faculty>($"api/Faculties/GetByNameFaculty/{nameFaculty}");
        }
        public async Task UpdateFaculty(int idFaculty, Faculty faculty)
        {
            await httpClient.PutAsJsonAsync<Faculty>($"api/Faculties/UpdateFaculty/{idFaculty}", faculty);
        }
    }
}