using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using inProject.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace inProject.Repositores
{
    public class SessionRepository : Repository<Session>, ISessionRepository
    {
        public SessionRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Session>> GetAllSessions()
        {
            return await _context.Sessions!
                .Include(s=>s.SoftwareUser)
                .Include(e=>e.Employee)
                .Include(s=>s.Software)
                .Include(s=>s.SoftwareModule)
                .ToListAsync()
                ?? throw new Exception("Session is not found");
        }

        public async Task<Session> GetSessionById(int id)
        {
            return await _context.Sessions!
                .Include(s => s.SoftwareUser)
                .Include(e => e.Employee)
                .Include(s => s.Software)
                .Include(s => s.SoftwareModule)
                .FirstOrDefaultAsync(e => e.Id == id)
                ?? throw new Exception("Session is not found");
        }

        public async Task<int> GetSessionCount()
        {
            var sessions = await _context.Sessions!.ToListAsync();
            return sessions.Count;
        }

    }
}
