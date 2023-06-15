using Elfie.Serialization;
using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface IResourceRepository : IRepository<Models.Domain.Resource>
    {
        Task<List<Models.Domain.Resource>> GetAllResources();
        Task<Models.Domain.Resource> GetResourceById(int id);
        Task<Models.Domain.Resource> GetResourceByName(string name);
        Task<int> GetResourceCount();
    }
}
