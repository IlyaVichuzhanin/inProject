using inProject.Models.Domain;
using inProject.Repositories.Interface;

namespace inProject.Repositores.Interface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> GetEmployeeByName(string name);
        Task<int> GetEmployeeCount();
    }
}
