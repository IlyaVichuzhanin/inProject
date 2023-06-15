using inProject.Models.Domain.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.EmployeeVM
{
    public class CreateEmployeeVM
    {
        [Required, Display(Name = "ФИО")]
        public string? FullName { get; set; }
        [Required, Display(Name = "Ресурс")]
        public int ResourceID { get; set; }
        [ValidateNever]
        public List<SelectListItem>? Resources { get; set; }
        [Display(Name = "Тип сотрудника")]
        public EmployeType EmployeType { get; set; }
        public int CompanyId { get; set; }
        [ValidateNever]
        public List<SelectListItem>? Companies { get; set; }
    }
}
