using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using inProject.Models.Domain.Enums;
using ResourceType = inProject.Models.Domain.Enums.ResourceType;

namespace inProject.Models.Domain
{
    public class Resource
    {
        public Resource()
        {
            Employees = new HashSet<Employee>();
            SoftwareModules = new HashSet<SoftwareModule>();
        }
        [Key]
        public int Id { get; set; }
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
        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual ICollection<SoftwareModule>? SoftwareModules { get; set; }
        public override string ToString()
        {
            return ResourceName;
        }
    }
}