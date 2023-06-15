using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface ISoftwareModuleRepository : IRepository<SoftwareModule>
    {
        Task<List<SoftwareModule>> GetAllSoftwareModules();
        Task<SoftwareModule> GetSoftwareModuleById(int id);
        Task<SoftwareModule> GetSoftwareModuleByName(string name);
        Task<int> GetSoftwareModuleCount();
    }
}
