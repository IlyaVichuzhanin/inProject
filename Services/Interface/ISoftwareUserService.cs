using inProject.Dtos.EmployeeDto;
using inProject.Dtos.SoftwareUserDto;

namespace inProject.Services.Interface
{
    public interface ISoftwareUserService
    {
        Task CreateAsync(CreateSoftwareUserDto createCompanyDto);
        Task UpdateAsync(UpdateSoftwareUserDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
