using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectResearcherMatchingAPI.Model;
using ProjectResearcherMatchingAPI.Repository;

namespace ProjectResearcherMatchingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var project = _projectRepository.GetProjects();
            return new OkObjectResult(project);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var project = _projectRepository.GetProjectByID(id);
            return new OkObjectResult(project);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Project project)
        {
            using (var scope = new TransactionScope())
            {
                _projectRepository.InsertProject(project);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = project.ProjectId }, project);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Project project)
        {
            if (project != null)
            {
                using (var scope = new TransactionScope())
                {
                    _projectRepository.UpdateProject(project);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projectRepository.DeleteProject(id);
            return new OkResult();
        }


        //// GET: api/Project
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Project/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Project
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Project/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
