using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectResearcherMatchingAPI.Model
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPublished { get; set; }
    }
}
