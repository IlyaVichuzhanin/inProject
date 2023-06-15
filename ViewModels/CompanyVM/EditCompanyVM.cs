using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.CompanyVM
{
    public class EditCompanyVM
    {
        public int Id { get; set; }
        [Required, Display(Name = "Название компании")]
        public string? CompanyName { get; set; }
    }
}
