using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.Dtos.SoftwareUserDto
{
    public class CreateSoftwareUserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? WindowsUserName { get; set; }
        public string? ComputerUserName { get; set; }
        public int? EmployeeId { get; set; }

    }
}
