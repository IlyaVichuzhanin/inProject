using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace inProject.ViewModels.SoftwareModuleVM
{
    public class EditSoftwareModuleVM
    {
        public int Id { get; set; }
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
