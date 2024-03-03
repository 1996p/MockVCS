namespace ooap_lab_1.Models
{
    public class Project : ICopyable<Project>
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime LastUpdateTime { get;set; }
        public string SourceCode { get; set; } = String.Empty;


        public Project(int id, string name, DateTime lastTimeUpdate, string sourceCode)
        {
            Id = id;
            Name = name;
            LastUpdateTime = lastTimeUpdate;
            SourceCode = sourceCode;
        }

        public Project Copy()
        {
            return new Project(Id, Name, LastUpdateTime, SourceCode);
        }
    }
}
