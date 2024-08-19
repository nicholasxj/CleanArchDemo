using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="courseService"></param>
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel courseViewModel)
        {
            _courseService.Create(courseViewModel);

            return Ok(courseViewModel);
        }

        // TODO: implement other CRUD methods

        // Read

        // Update

        // Delete/Deactivate

    }
}
