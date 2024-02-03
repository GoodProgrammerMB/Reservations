namespace Reservations.Api.Commands
{
	public record CreateReservation(Guid PlaceId, Guid ReservationId, string PersonNam );

}
