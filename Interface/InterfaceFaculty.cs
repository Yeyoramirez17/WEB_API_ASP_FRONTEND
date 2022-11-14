using WEB_API_FRONTEND.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WEB_API_FRONTEND.Interface
{
    public interface InterfaceFaculty
    {
        public Task<List<Faculty>> GetAll();
        public Task<Faculty> GetById(int id);
        public Task<Faculty> GetByNameFaculty(string nameFaculty);
        public Task<Faculty> CreateFaculty(Faculty faculty);
        public Task UpdateFaculty(int idFaculty, Faculty faculty);
        public Task DeleteFaculty(int idFaculty);
    }
}