using Reservations.Core.Entities;

namespace Reservations.Core.Repositories
{
	public interface IReservationRepository
	{
		public IEnumerable<Reservation> GetAll();
		public Reservation Get(Guid id);
		public void Add(Reservation reservation);
		public void Update(Reservation reservation);
		public void Delete(Guid id);
	}
}
