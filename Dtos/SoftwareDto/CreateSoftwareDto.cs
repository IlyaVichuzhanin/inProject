using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace inProject.Dtos.SoftwareDto
{
    public class CreateSoftwareDto
    {
        public int Id { get; set; }
        public string? SoftwareName { get; set; }

    }
}
