using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inProject.ViewModels.SoftwareUserVM
{
    public class EditSoftwareUserVM
    {
        public int? Id { get; set; }
        [Required, Display(Name = "Пользователь")]
        public string? UserName { get; set; }
        [Required, Display(Name = "Учетная запись Windows")]
        public string? WindowsUserName { get; set; }
        [Required, Display(Name = "Имя компьютера")]
        public string? ComputerUserName { get; set; }
        [Required, Display(Name = "Сотрудник")]
        public int? EmployeeId { get; set; }
        [ValidateNever]
        public List<SelectListItem>? Employees { get; set; }

    }
}
