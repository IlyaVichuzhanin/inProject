using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inProject.Models.Domain
{
    public class Software
    {
        public Software()
        {
            SoftwareModules = new HashSet<SoftwareModule>();
            Sessions = new HashSet<Session>();
            StructuredLogs = new HashSet<StructuredLog>();
        }
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Програмное обеспечение")]
        public string SoftwareName { get; set; }
        public virtual ICollection<SoftwareModule>? SoftwareModules { get; set; }
        public virtual ICollection<Session>? Sessions { get; set; }
        public virtual ICollection<StructuredLog>? StructuredLogs { get; set; }
        public override string ToString()
        {
            return SoftwareName;
        }
    }
}
