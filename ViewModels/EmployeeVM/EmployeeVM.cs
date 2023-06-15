using inProject.Models.Domain.Enums;
using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.EmployeeVM
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Display(Name = "ФИО")]
        public string? FullName { get; set; }
        [Display(Name = "Ресурс")]
        public string? ResourceName { get; set; }
        [Display(Name = "Тип сотрудника")]
        public EmployeType EmployeType { get; set; }
        [Display(Name = "Компания")]
        public string? CompanyName { get; set; }
    }
}
