using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface ISessionRepository : IRepository<Session>
    {
        Task<List<Session>> GetAllSessions();
        Task<Session> GetSessionById(int id);
        Task<int> GetSessionCount();
    }
}
