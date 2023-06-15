using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inProject.Models.Domain.Enums;

namespace inProject.Models.Domain
{
    public class Employee
    {
        public Employee()
        {
            Sessions = new HashSet<Session>();
            SoftwareUsers = new HashSet<SoftwareUser>();
            StructuredLogs = new HashSet<StructuredLog>();

        }
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "ФИО")]
        public string? FullName { get; set; }
        [Required, Display(Name = "Ресурс")]
        public int ResourceID { get; set; }
        [ForeignKey("ResourceID"), Display(Name = "Ресурс")]
        public Resource? Resource { get; set; }
        [Display(Name = "Тип сотрудника")]
        public EmployeType EmployeType { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId"), Display(Name = "Компания")]
        public virtual Company? Company { get; set; }
        public virtual ICollection<Session>? Sessions { get; set; }
        public virtual ICollection<SoftwareUser>? SoftwareUsers { get; set; }
        public virtual ICollection<StructuredLog>? StructuredLogs { get; set; }
        public override string ToString()
        {
            return FullName;
        }
    }
}
