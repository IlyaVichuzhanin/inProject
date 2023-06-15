using inProject.Dtos.EmployeeDto;
using inProject.Dtos.ResourceDto;

namespace inProject.Services.Interface
{
    public interface IResourceService
    {
        Task CreateAsync(CreateResourceDto createCompanyDto);
        Task UpdateAsync(UpdateResourceDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
