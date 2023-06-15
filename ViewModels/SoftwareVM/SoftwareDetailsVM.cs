using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SoftwareVM
{
    public class SoftwareDetailsVM
    {
        public int Id { get; set; }
        [Display(Name = "Програмное обеспечение")]
        public string? SoftwareName { get; set; }
    }
}
