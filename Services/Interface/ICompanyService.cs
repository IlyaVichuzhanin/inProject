using inProject.Dtos.CompanyDto;

namespace inProject.Services.Interface
{
    public interface ICompanyService
    {
        Task CreateAsync(CreateCompanyDto createCompanyDto);
        Task UpdateAsync(UpdateCompanyDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
