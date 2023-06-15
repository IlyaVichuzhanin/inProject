using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface ISoftwareRepository : IRepository<Software>
    {
        Task<List<Software>> GetAllSoftwares();
        Task<Software> GetSoftwareById(int id);
        Task<Software> GetSoftwareByName(string name);
        Task<int> GetSoftwareCount();
    }
}
