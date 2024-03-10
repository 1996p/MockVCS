namespace MudBlazorWebApp1.Components.Models
{
    [Serializable]
    public class Commit
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public string SourceCode { get; set; } = String.Empty;
        public Commit() { }
        public Commit(string message, string sourceCode) 
        {
            Message = message;
            DateTime = DateTime.Now;
            SourceCode = sourceCode;
        }
    }
}
