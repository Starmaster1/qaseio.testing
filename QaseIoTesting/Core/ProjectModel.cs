namespace Core
{
    public class ProjectModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ProjectAccessType { get; set; }
        public string MemberAccess { get; set; }

        public override string? ToString()
        {
            return $"Code: {Code} Title:{Title} Description: {Description} ";
        }
    }
}
