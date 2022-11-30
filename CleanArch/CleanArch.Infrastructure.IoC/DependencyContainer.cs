﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Bus;
using CleanArch.Infrastructure.Data.Context;
using CleanArch.Infrastructure.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
			//services.AddSingleton<ILogger<CourseController>>();

			// Domain InMemoryBus MediatR
			services.AddScoped<IMediatorHandler, InMemoryBus>();

			// Domain Handlers
			services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

			// Application Layer
			services.AddScoped<ICourseService, CourseService>();

			// Infra.Data Layer
			services.AddScoped<ICourseRepository, CourseRepository>();
			services.AddScoped<UniversityDbContext>();
		}
	}
}
