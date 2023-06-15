namespace inProject.Dtos.SoftwareModuleDto
{
    public class UpdateSoftwareModuleDto
    {
        public int Id { get; set; }
        public string? SoftwareModuleName { get; set; }
        public int ResourceID { get; set; }
        public int SoftwareId { get; set; }
    }
}
