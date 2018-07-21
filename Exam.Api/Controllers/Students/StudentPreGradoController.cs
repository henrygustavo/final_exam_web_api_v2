using Exam.Application.Service.Students;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Api.Controllers.Students
{
    [Produces("application/json")]
    [Route("api/students/degreeType/pregrado")]
    public class StudentPreGradoController : Controller
    {
        private readonly IStudentPreGradoApplicationService _studentPreGradoApplicationService;

        public StudentPreGradoController(
          IStudentPreGradoApplicationService studentPreGradoApplicationService
          )
        {
            _studentPreGradoApplicationService = studentPreGradoApplicationService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentPreGradoApplicationService.GetAll());
        }
    }
}