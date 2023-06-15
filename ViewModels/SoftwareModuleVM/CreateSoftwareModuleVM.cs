using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareModuleVM
{
    public class CreateSoftwareModuleVM
    {
        [Required, Display(Name = "Модуль")]
        public string? SoftwareModuleName { get; set; }
        [Required]
        public int ResourceID { get; set; }
        [ValidateNever]
        public List<SelectListItem>? Resources { get; set; }
        [Required]
        public int SoftwareId { get; set; }
        public List<SelectListItem>? Softwares { get; set; }
    }
}
