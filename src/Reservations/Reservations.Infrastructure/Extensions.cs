using Microsoft.Extensions.DependencyInjection;
using Reservations.Core.Repositories;
using Reservations.Infrastructure.Repositories;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Reservations.Tests.Unit")]
namespace Reservations.Infrastructure
{
	public static class Extensions
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services)
		{
			services.AddSingleton<IReservationRepository, ReservationRepository>();
			return services;
		}
	}
}
