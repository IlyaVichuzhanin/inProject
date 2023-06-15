using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inProject.ViewModels.SessionVM
{
    public class CreateSessionVM
    {
        [Required]
        public int SoftwareUserId { get; set; }
        
        public List<SelectListItem>? SoftwareUsers { get; set; }
        [Required]
        public int EmployeeId { get; set; }

        public List<SelectListItem>? Employees { get; set; }
        [Required]
        public int SoftwareId { get; set; }

        public List<SelectListItem>? Softwares { get; set; }
        [Required]
        public int SoftwareModuleId { get; set; }
        public List<SelectListItem>? SoftwareModules { get; set; }
        [Required]
        public DateTime LogInDateTime { get; set; }
        public DateTime LogOutDateTime { get; set; }
    }
}
