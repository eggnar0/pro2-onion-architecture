using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Onion.Domain.Entities;
using Onion.Domain.Services;

namespace Onion.UI.Api.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentDbService _service;

        public StudentsController(IStudentDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_service.GetStudents());
        }

        [HttpPost]
        public IActionResult EnrollStudent(Student newStudent)
        {
            return Ok(_service.EnrollStudent(newStudent, 2020));
        }
    }
}