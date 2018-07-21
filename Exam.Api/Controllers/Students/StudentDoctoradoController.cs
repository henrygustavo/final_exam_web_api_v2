using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Application.Service.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Api.Controllers.Students
{
    [Produces("application/json")]
    [Route("api/students/degreeType/doctorado")]
    public class StudentDoctoradoController : Controller
    {

        private readonly IStudentDoctoradoApplicationService _studentDoctoradoApplicationService;

        public StudentDoctoradoController(IStudentDoctoradoApplicationService 
                                            studentDoctoradoApplicationService
            )
        {
            _studentDoctoradoApplicationService = studentDoctoradoApplicationService;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentDoctoradoApplicationService.GetAll());
        }
    }
}