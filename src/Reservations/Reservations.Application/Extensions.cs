
using Microsoft.Extensions.DependencyInjection;
using Reservations.Application.Services;

namespace Reservations.Application
{
	public static class Extensions
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services
				.AddSingleton<IClock, Clock>()
				.AddScoped<ReservationService>();

			return services;
		}
	}
}
