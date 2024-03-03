using Microsoft.AspNetCore.Connections.Features;

namespace ooap_lab_1.Models
{
    public class ProjectFactory
    {
        private Project? currentProject = null;

        public ProjectFactory(Project project) 
        {
            currentProject = project;
        }

        public Project CopyProject()
        {
            if (currentProject == null) 
                throw new NullReferenceException(nameof(currentProject));

            return currentProject.Copy();
        }
    }
}
