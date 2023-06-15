using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareUserVM
{
    public class CreateSoftwareUserVM
    {
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
