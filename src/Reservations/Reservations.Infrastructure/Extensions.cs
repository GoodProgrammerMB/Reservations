using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reservations.Application.Services;
using Reservations.Core.Repositories;
using Reservations.Infrastructure.DAL.Repositories;
using Reservations.Infrastructure.Exceptions;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;


[assembly: InternalsVisibleTo("Reservations.Tests.Unit")]
namespace Reservations.Infrastructure
{
    public static class Extensions
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton<IReservationRepository, ReservationRepository>();

			var section = configuration.GetSection("app");
			services.Configure<AppOptions>(section);

			services.AddSingleton<ExceptionMiddleware>();

			services.AddSingleton<IClock, Clock>();

			return services;
		}

		public static WebApplication UseInfrastructure(this WebApplication app)
		{
			app.UseMiddleware<ExceptionMiddleware>();
			return app;
		}
	}
}
