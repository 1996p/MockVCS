using MudBlazorWebApp1.Components.Models;
using System.Collections.Generic;

namespace ooap_lab_1.Models
{
    public class Project : ICopyable<Project>
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<Commit> Commits { get; set; } = new();

        public Project()
        {
           
        }

        public Project(int id, string name, List<Commit> commits)
        {
            Id = id;
            Name = name;
            
            foreach(Commit commit in commits)
            {
                Commits.Add(new Commit(commit.Message, commit.SourceCode));
            }
        }

        public Project Copy()
        {
            return new Project(Id, Name, Commits);
        }
    }
}
