namespace Reservations.Application.Services
{
	public class Clock: IClock
	{
		public DateTime Current() => DateTime.UtcNow;
	}
}
