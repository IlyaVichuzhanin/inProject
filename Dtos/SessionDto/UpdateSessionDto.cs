namespace inProject.Dtos.SessionDto
{
    public class UpdateSessionDto
    {
        public int Id { get; set; }
        public int SoftwareUserId { get; set; }
        public int EmployeeId { get; set; }
        public int SoftwareId { get; set; }
        public int SoftwareModuleId { get; set; }
        public DateTime LogInDateTime { get; set; }
        public DateTime LogOutDateTime { get; set; }
    }
}
