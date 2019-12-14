using Microsoft.EntityFrameworkCore;
using ProjectResearcherMatchingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResearcherMatchingAPI.DBContexts
{
    public class ProjectContext :DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }      

    }
}
