using inProject.Dtos.CompanyDto;
using inProject.Models.Domain;
using inProject.Repositores.Interface;
using inProject.Repositories.Interface;
using inProject.Services.Interface;

namespace inProject.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(CreateCompanyDto createCompanyDto)
        {
            var company = new Company()
            {
                CompanyName= createCompanyDto.CompanyName
            };
            await _unitOfWork.CreateAsync(company);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var company = await _companyRepository.GetByAsync(x => x.Id == id);
            await _unitOfWork.DeleteAsync(company);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(UpdateCompanyDto updateCompanyDto)
        {
            var company = await _companyRepository.GetByAsync(x => x.Id == updateCompanyDto.Id);
            company.CompanyName = updateCompanyDto.CompanyName;
            
            await _unitOfWork.UpdateAsync(company);
            await _unitOfWork.SaveAsync();
        }
    }
}
