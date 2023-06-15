using inProject.Dtos.CompanyDto;
using inProject.Dtos.EmployeeDto;

namespace inProject.Services.Interface
{
    public interface IEmployeeService
    {
        Task CreateAsync(CreateEmployeeDto createCompanyDto);
        Task UpdateAsync(UpdateEmployeeDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
