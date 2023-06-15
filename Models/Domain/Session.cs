using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inProject.Models.Domain
{
    public class Session
    {
        public Session()
        {

        }
        [Key]
        public int Id { get; set; }
        public int SoftwareUserId { get; set; }
        [Required, ForeignKey("SoftwareUserId"), Display(Name = "Имя пользователя")]
        public virtual SoftwareUser? SoftwareUser { get; set; }
        public int EmployeeId { get; set; }
        [Required, ForeignKey("EmployeeId"), Display(Name = "Сотрудник")]
        public virtual Employee? Employee { get; set; }
        public int SoftwareId { get; set; }
        [Required, ForeignKey("SoftwareId"), Display(Name = "Программное обеспечение")]
        public virtual Software? Software { get; set; }
        public int SoftwareModuleId { get; set; }
        [Required, ForeignKey("SoftwareModuleId"), Display(Name = "Модуль")]
        public virtual SoftwareModule? SoftwareModule { get; set; }
        [Display(Name = "Начало сессии")]
        public DateTime LogInDateTime { get; set; }
        [Display(Name = "Окончание сессии")]
        public DateTime LogOutDateTime { get; set; }
        [Display(Name = "Время работы")]
        public double SessionTime
        {
            get { return (LogOutDateTime - LogInDateTime).TotalHours; }
        }
        public bool SessionIsFinished { get; set; }
        //public bool SessionIsDevided { get; set; }
    }
}

