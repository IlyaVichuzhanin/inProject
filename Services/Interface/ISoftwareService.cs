using inProject.Dtos.EmployeeDto;
using inProject.Dtos.SoftwareDto;

namespace inProject.Services.Interface
{
    public interface ISoftwareService
    {
        Task CreateAsync(CreateSoftwareDto createCompanyDto);
        Task UpdateAsync(UpdateSoftwareDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
