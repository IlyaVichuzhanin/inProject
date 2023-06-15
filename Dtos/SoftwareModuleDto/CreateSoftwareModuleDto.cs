using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.Dtos.SoftwareModuleDto
{
    public class CreateSoftwareModuleDto
    {
        public int Id { get; set; }
        public string? SoftwareModuleName { get; set; }
        public int ResourceID { get; set; }
        public int SoftwareId { get; set; }
    }
}
