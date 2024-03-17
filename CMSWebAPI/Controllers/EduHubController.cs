using CMSWebAPI.Business;
using CMSWebAPI.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMSWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EduHubController : ControllerBase
    {
        private readonly IEduHubService _eduHubService;

        public EduHubController(IEduHubService eduHubService)
        {
            _eduHubService = eduHubService;
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _eduHubService.Add(student);

            return StatusCode(201);
        }

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _eduHubService.GetAllStudents();
            return Ok(students);
        }

        [HttpPost("ClearAllStudents")]
        public IActionResult ClearAllStudents()
        {
            _eduHubService.ClearAllStudents();
            return Ok();
        }

    }
}
