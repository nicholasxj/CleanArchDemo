using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.IoC
{
    public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Application Layer
			services.AddScoped<ICourseService, CourseService>();

			// Infra.Data
			services.AddScoped<ICourseRepository, CourseRepository>();
		}
	}
}
