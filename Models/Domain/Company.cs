using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inProject.Models.Domain
{
    public class Company
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
        }
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Название компании")]
        public string? CompanyName { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
        public override string ToString()
        {
            return CompanyName;
        }
    }
}

