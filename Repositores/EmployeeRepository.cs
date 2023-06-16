using inProject.Data;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories;
using Microsoft.EntityFrameworkCore;

namespace inProject.Repositores
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _context.Employees!
                .Include(c=>c.Company)
                .Include(r=>r.Resource)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees!
                .Include(c => c.Company)
                .Include(r => r.Resource)
                .FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new Exception("Employee is not found");
        }

        public async Task<Employee> GetEmployeeByName(string name)
        {
            return await _context.Employees!
                .Include(c => c.Company)
                .Include(r => r.Resource)
                .FirstOrDefaultAsync(x => x.FullName == name)
                ?? throw new Exception("Employee is not found");
        }

        public async Task<int> GetEmployeeCount()
        {
            var emplyees = await _context.Employees!.ToListAsync();
            return emplyees.Count();
        }
    }
}
