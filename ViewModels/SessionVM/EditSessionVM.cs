using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inProject.ViewModels.SessionVM
{
    public class EditSessionVM
    {
        public int Id { get; set; }
        public int SoftwareUserId { get; set; }
        [Required]
        public List<SelectListItem>? SoftwareUsers { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public List<SelectListItem>? Employees { get; set; }
        public int SoftwareId { get; set; }
        [Required]
        public List<SelectListItem>? Softwares { get; set; }
        public int SoftwareModuleId { get; set; }
        [Required]
        public List<SelectListItem>? SoftwareModules { get; set; }
        [Required]
        public DateTime LogInDateTime { get; set; }
        public DateTime LogOutDateTime { get; set; }
    }
}
