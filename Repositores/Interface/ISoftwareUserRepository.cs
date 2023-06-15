using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface ISoftwareUserRepository : IRepository<SoftwareUser>
    {
        Task<List<SoftwareUser>> GetAllSoftwareUsers();
        Task<SoftwareUser> GetSoftwareUserById(int id);
        Task<SoftwareUser> GetSoftwareUserByName(string name);
        Task<int> GetSoftwareUserCount();
    }
}
