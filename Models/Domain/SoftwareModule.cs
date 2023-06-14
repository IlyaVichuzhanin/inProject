using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inProject.Models.Domain
{
    public class SoftwareModule
    {
        public SoftwareModule()
        {
            Sessions = new HashSet<Session>();
            StructuredLogs = new HashSet<StructuredLog>();
        }
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Модуль")]
        public string SoftwareModuleName { get; set; }
        //Resource
        public int ResourceID { get; set; }
        [ForeignKey("ResourceID"), Display(Name = "Ресурс")]
        public virtual Resource? Resource { get; set; }

        public int SoftwareId { get; set; }
        [ForeignKey("SoftwareId"), Display(Name = "Программное обеспечение")]
        public virtual Software? Software { get; set; }
        public virtual ICollection<Session>? Sessions { get; set; }
        public virtual ICollection<StructuredLog>? StructuredLogs { get; set; }

        public override string ToString()
        {
            return SoftwareModuleName;
        }
    }
}
