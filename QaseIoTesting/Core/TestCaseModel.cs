namespace Core
{
    public class TestCaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Severity { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Layer { get; set; }

        public override string? ToString()
        {
            return $"Title:{Title} Description: {Description} ";
        }
    }
}
