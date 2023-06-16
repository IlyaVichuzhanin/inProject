using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace inProject.Repositores
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Company>> GetAllCompanies()
        {
            return await _context.Companies!.ToListAsync();
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await _context.Companies!.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception("Company is not found");
        }

        public async Task<Company> GetCompanyByName(string name)
        {
            return await _context.Companies!.FirstOrDefaultAsync(x => x.CompanyName == name) ?? throw new Exception("Company is not found");
        }

        public async Task<int> GetCompanyCount()
        {
            var companies = await _context.Companies!.ToListAsync();
            return companies.Count();
        }
    }
}
