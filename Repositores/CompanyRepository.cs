using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;

namespace inProject.Repositores
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<Company>> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCompanyCount()
        {
            throw new NotImplementedException();
        }
    }
}
