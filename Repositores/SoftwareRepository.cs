using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System.Linq.Expressions;

namespace inProject.Repositores
{
    public class SoftwareRepository : Repository<Software>, ISoftwareRepository
    {
        public SoftwareRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Software>> GetAllSoftwares()
        {
            return await _context.Softwares!
                .ToListAsync();
        }


        public async Task<Software> GetSoftwareById(int id)
        {
            return await _context.Softwares!
                .FirstOrDefaultAsync(x=>x.Id==id)
                ?? throw new Exception("Softwatre is not found");
        }

        public async Task<Software> GetSoftwareByName(string name)
        {
            return await _context.Softwares!
                .FirstOrDefaultAsync(x => x.SoftwareName == name)
                ?? throw new Exception("Softwatre is not found");
        }

        public async Task<int> GetSoftwareCount()
        {
            var software = await _context.Softwares!.ToListAsync();
            return software.Count;
        }
    }
}
