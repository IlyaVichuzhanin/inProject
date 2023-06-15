using inProject.Dtos.SessionDto;

namespace inProject.Services.Interface
{
    public interface ISessionService
    {
        Task CreateAsync(CreateSessionDto createCompanyDto);
        Task UpdateAsync(UpdateSessionDto updateCompanyDto);
        Task DeleteAsync(int id);
    }
}
