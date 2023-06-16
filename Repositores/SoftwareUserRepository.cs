using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace inProject.Repositores
{
    public class SoftwareUserRepository : Repository<SoftwareUser>, ISoftwareUserRepository
    {
        public SoftwareUserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<SoftwareUser>> GetAllSoftwareUsers()
        {
            return await _context.SoftwareUsers!
                .Include(e=>e.Employee)
                .ToListAsync();
        }

        public async Task<SoftwareUser> GetSoftwareUserById(int id)
        {
            return await _context.SoftwareUsers!
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(s => s.Id == id)
                ?? throw new Exception("SoftwareUser is not found");
        }

        public async Task<SoftwareUser> GetSoftwareUserByName(string name)
        {
            return await _context.SoftwareUsers!
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(s => s.UserName == name)
                ?? throw new Exception("SoftwareUser is not found");
        }

        public async Task<int> GetSoftwareUserCount()
        {
            var users = await _context.SoftwareUsers!.ToListAsync();
            return users.Count();
        }
    }
}
