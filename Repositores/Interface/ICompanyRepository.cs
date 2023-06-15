using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<List<Company>> GetAllCompanies();
        Task<Company> GetCompanyById(int id);
        Task<Company> GetCompanyByName(string name);
        Task<int> GetCompanyCount();

    }
}
