namespace Exam.Api.Controllers.Students
{
    using Exam.Application.Service.Students;
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/students")]
    public class StudentController : Controller
    {

        private readonly IStudentApplicationService _studentApplicationService;

        public StudentController(IStudentApplicationService studentApplicationService
            )
        {
            _studentApplicationService = studentApplicationService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentApplicationService.GetAll());
        }
    }
}