namespace BussinesObjects.API.RestEntities
{
    public class Entity
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
        public object Description { get; set; }
        public object Preconditions { get; set; }
        public object Postconditions { get; set; }
        public int Severity { get; set; }
        public int Priority { get; set; }
        public int Type { get; set; }
        public int Layer { get; set; }
        public int IsFlaky { get; set; }
        public int Behavior { get; set; }
        public int Automation { get; set; }
        public int Status { get; set; }
        public object MilestoneId { get; set; }
        public object SuiteId { get; set; }
        public List<object> Links { get; set; }
        public List<object> CustomFields { get; set; }
        public List<object> Attachments { get; set; }
        public object StepsType { get; set; }
        public List<object> Steps { get; set; }
        public List<object> Params { get; set; }
        public int MemberId { get; set; }
        public int AuthorId { get; set; }
        public List<object> Tags { get; set; }
        public object Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
