using Reservations.Api.Commands;
using Reservations.Api.DTO;

namespace Reservations.Api.Services
{
	public class ReservationService
	{
		public ReservationDto Get(Guid id)
		{
			return new ReservationDto { Id = id };
		}

		public IEnumerable<ReservationDto> GetAll()
		{
			return new List<ReservationDto>();
		}

		public Guid? Create(CreateReservation comand)
		{
			return null;
		}

		public bool Update(ChangeReservation comand)
		{
			return false;
		}

		public bool Delete(Guid id)
		{
			return false;
		}
	}
}
