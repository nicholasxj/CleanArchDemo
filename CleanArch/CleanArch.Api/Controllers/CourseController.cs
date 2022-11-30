using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            if (courseViewModel == null)
            {
                return BadRequest(courseViewModel);
            }

            _courseService.CreateCourse(courseViewModel);

            return Ok(courseViewModel);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var courses = _courseService.GetCourses();

            if (courses == null)
            {
                return NotFound(courses);
            }

            return Ok(courses);
        }
    }
}
