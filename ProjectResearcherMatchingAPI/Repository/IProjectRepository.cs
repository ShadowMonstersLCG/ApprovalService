using ProjectResearcherMatchingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResearcherMatchingAPI.Repository
{
    public interface IProjectRepository
    {
        Project GetProjectByID(int ProjectId);
        IEnumerable<Project> GetProjects();

        void UpdateProject(Project project);

        void InsertProject(Project project);

        void DeleteProject(int ProjectId);

        void Save();

    }
}
