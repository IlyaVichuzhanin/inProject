using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareUserVM
{
    public class SoftwareUserVM
    {
        public int? Id { get; set; }
        [Display(Name = "Пользователь")]
        public string? UserName { get; set; }
        [Display(Name = "Учетная запись Windows")]
        public string? WindowsUserName { get; set; }
        [Display(Name = "Имя компьютера")]
        public string? ComputerUserName { get; set; }
        [Display(Name = "Сотрудник")]
        public string? EmployeeName { get; set; }
    }
}
