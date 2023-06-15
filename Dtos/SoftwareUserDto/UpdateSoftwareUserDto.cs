namespace inProject.Dtos.SoftwareUserDto
{
    public class UpdateSoftwareUserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? WindowsUserName { get; set; }
        public string? ComputerUserName { get; set; }
        public int? EmployeeId { get; set; }
    }
}
