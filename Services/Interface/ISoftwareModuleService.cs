using inProject.Dtos.EmployeeDto;
using inProject.Dtos.SoftwareModuleDto;

namespace inProject.Services.Interface
{
    public interface ISoftwareModuleService
    {
        Task CreateAsync(CreateSoftwareModuleDto createCompanyDto);
        Task UpdateAsync(UpdateSoftwareModuleDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
