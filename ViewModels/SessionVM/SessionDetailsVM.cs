using System.ComponentModel.DataAnnotations;

namespace inProject.ViewModels.SessionVM
{
    public class SessionDetailsVM
    {
        public int Id { get; set; }
        [Display(Name = "Имя пользователя")]
        public string? SoftwareUserName { get; set; }
        [Display(Name = "Сотрудник")]
        public string? EmployeeName { get; set; }
        [Display(Name = "Программное обеспечение")]
        public string? SoftwareName { get; set; }
        [Display(Name = "Модуль")]
        public string? SoftwareModuleName { get; set; }
        [Display(Name = "Начало сессии")]
        public DateTime LogInDateTime { get; set; }
        [Display(Name = "Окончание сессии")]
        public DateTime LogOutDateTime { get; set; }
        [Display(Name = "Время работы")]
        public double SessionTime
        {
            get { return (LogOutDateTime - LogInDateTime).TotalHours; }
        }
    }
}
