using inProject.Models.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.ResourceVM
{
    public class CreateResourceVM
    {
        [Required, Display(Name = "Название ресурса")]
        public string? ResourceName { get; set; }
        [Display(Name = "Id ресурса в MS Project")]
        public int ProjectResourceId { get; set; }
        [Display(Name = "Тип ресурса")]
        public ResourceType ResourceType { get; set; }
        [Display(Name = "Категория ресурса")]
        public ResourceCategory ResourceCategory { get; set; }
        [Display(Name = "Состояние ресурса")]
        public ResourceUsageState ResourceUsageState { get; set; }
    }
}
