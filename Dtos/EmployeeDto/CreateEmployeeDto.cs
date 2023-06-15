using inProject.Models.Domain.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.Dtos.EmployeeDto
{
    public class CreateEmployeeDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int ResourceID { get; set; }
        public EmployeType EmployeType { get; set; }
        public int CompanyId { get; set; }

    }
}
