using inProject.Models.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace inProject.Dtos.ResourceDto
{
    public class CreateResourceDto
    {
        public int Id { get; set; }
        public string? ResourceName { get; set; }
        public int ProjectResourceId { get; set; }
        public ResourceType ResourceType { get; set; }
        public ResourceCategory ResourceCategory { get; set; }
        public ResourceUsageState ResourceUsageState { get; set; }
    }
}
