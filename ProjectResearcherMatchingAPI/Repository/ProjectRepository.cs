using Microsoft.EntityFrameworkCore;
using ProjectResearcherMatchingAPI.DBContexts;
using ProjectResearcherMatchingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResearcherMatchingAPI.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProjectContext _dbContext;

        public ProjectRepository(ProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProject(int projectId)
        {
            var project = _dbContext.Projects.Find(projectId);
            _dbContext.Projects.Remove(project);
            Save();
        }

        public Project GetProjectByID(int projectId)
        {
            return _dbContext.Projects.Find(projectId);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            _dbContext.Entry(project).State = EntityState.Modified;
            Save();
        }

        public void InsertProject(Project project)
        {
            _dbContext.Add(project);
            Save();
        }
    }
}
