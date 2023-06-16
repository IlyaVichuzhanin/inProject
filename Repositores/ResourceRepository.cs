using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace inProject.Repositores
{
    public class ResourceRepository : Repository<Resource>, IResourceRepository
    {
        public ResourceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Resource>> GetAllResources()
        {
            return await _context.Resources!.ToListAsync();
        }

        public async Task<Resource> GetResourceById(int id)
        {
            return await _context.Resources!
                .FirstOrDefaultAsync(x => x.Id == id) 
                ?? throw new Exception("Resource is not found");
        }

        public async Task<Resource> GetResourceByName(string name)
        {
            return await _context.Resources!
                .FirstOrDefaultAsync(x => x.ResourceName == name) 
                ?? throw new Exception("Resource is not found");
        }

        public async Task<int> GetResourceCount()
        {
            var resources = await _context.Resources!.ToListAsync();
            return resources.Count;
        }
    }
}
