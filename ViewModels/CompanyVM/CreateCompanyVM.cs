using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.CompanyVM
{
    public class CreateCompanyVM
    {
        [Required, Display(Name = "Название компании")]
        public string? CompanyName { get; set; }
    }
}
