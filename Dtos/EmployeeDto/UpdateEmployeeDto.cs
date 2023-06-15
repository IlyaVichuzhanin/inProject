using inProject.Models.Domain.Enums;

namespace inProject.Dtos.EmployeeDto
{
    public class UpdateEmployeeDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int ResourceID { get; set; }
        public EmployeType EmployeType { get; set; }
        public int CompanyId { get; set; }
    }
}
