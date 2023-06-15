using inProject.Models.Domain.Enums;
using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inProject.ViewModels.EmployeeVM
{
    public class EditEmployee
    {
        public int Id { get; set; }
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
