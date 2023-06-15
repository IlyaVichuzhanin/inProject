using inProject.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareModuleVM
{
    public class SoftwareModuleVM
    {
        public int Id { get; set; }
        [Display(Name = "Модуль")]
        public string? SoftwareModuleName { get; set; }
        [Display(Name = "Ресурс")]
        public string? ResourceName { get; set; }
        [Display(Name = "Программное обеспечение")]
        public string? SoftwareName { get; set; }
    }
}
