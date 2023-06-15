using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inProject.Models.Domain
{
    public class SoftwareUser
    {
        public SoftwareUser()
        {
            Sessions = new HashSet<Session>();
            StructuredLogs = new HashSet<StructuredLog>();
        }
        [Key]
        public int? Id { get; set; }
        [Required, Display(Name = "Пользователь")]
        public string? UserName { get; set; }
        [Required, Display(Name = "Учетная запись Windows")]
        public string? WindowsUserName { get; set; }
        [Display(Name = "Имя компьютера")]
        public string? ComputerUserName { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId"), Display(Name = "Сотрудник")]
        public virtual Employee? Employee { get; set; }
        public virtual ICollection<Session>? Sessions { get; set; }
        public virtual ICollection<StructuredLog>? StructuredLogs { get; set; }
        public override string ToString()
        {
            return WindowsUserName;
        }
    }
}