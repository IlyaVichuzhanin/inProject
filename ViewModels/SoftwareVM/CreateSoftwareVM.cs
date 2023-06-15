using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareVM
{
    public class CreateSoftwareVM
    {
        
        [Required, Display(Name = "Програмное обеспечение")]
        public string? SoftwareName { get; set; }
    }
}
