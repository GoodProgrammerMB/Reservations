namespace Reservations.Application.Commands
{
	public record CreateReservation(Guid PlaceId, Guid ReservationId, string PersonNam );

}
