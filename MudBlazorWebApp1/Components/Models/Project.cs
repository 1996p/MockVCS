using MudBlazorWebApp1.Components.Models;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ooap_lab_1.Models
{
    [Serializable]
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

        public Project CopyWithSerialization()
        {
            object project = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
#pragma warning disable SYSLIB0011 // Тип или член устарел
                var binFormatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Тип или член устарел

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                project = binFormatter.Deserialize(tempStream);
            }
            return (Project)project;
        }
    }
}
