using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System.Linq.Expressions;

namespace inProject.Repositores
{
    public class SoftwareModuleRepository : Repository<SoftwareModule>, ISoftwareModuleRepository
    {
        public SoftwareModuleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<SoftwareModule>> GetAllSoftwareModules()
        {
            return await _context.SoftwareModules!
                .Include(s=>s.Software)
                .ToListAsync();
        }


        public async Task<SoftwareModule> GetSoftwareModuleById(int id)
        {
            return await _context.SoftwareModules!
                .Include(s=>s.Software)
                .FirstOrDefaultAsync(x=>x.Id==id)
                ?? throw new Exception("SoftwatreModule is not found");
        }

        public async Task<SoftwareModule> GetSoftwareModuleByName(string name)
        {
            return await _context.SoftwareModules!
                .Include(s => s.Software)
                .FirstOrDefaultAsync(x => x.SoftwareModuleName == name)
                ?? throw new Exception("SoftwatreModule is not found");
        }

        public async Task<int> GetSoftwareModuleCount()
        {
            var softwareModules = await _context.SoftwareModules!.ToListAsync();
            return softwareModules.Count;
        }
    }
}
