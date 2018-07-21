using Exam.Application.Service.Students;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Api.Controllers.Students
{
    [Produces("application/json")]
    [Route("api/students/degreeType/maestria")]
    public class StudentMaestriaController : Controller
    {
        private readonly IStudentMaestriaApplicationService _studentMaestriaApplicationService;

        public StudentMaestriaController(
          IStudentMaestriaApplicationService studentMaestriaApplicationService
          )
        {
            _studentMaestriaApplicationService = studentMaestriaApplicationService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentMaestriaApplicationService.GetAll());
        }
    }
}