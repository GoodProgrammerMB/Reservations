namespace Reservations.Api.DTO
{
	public class ReservationDto
	{
		public Guid Id { get; set; }
		public string PersonBooking { get; set; }
		public string PlaceName { get; set; }
		public DateTime Date { get; set; }
	}
}
