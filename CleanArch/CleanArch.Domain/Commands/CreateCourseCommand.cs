using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        /// <summary>
        /// class constructor.
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="imageUrl"></param>
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
    }
}
