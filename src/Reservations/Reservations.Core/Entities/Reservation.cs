using Reservations.Core.Exceptions;

namespace Reservations.Core.Entities
{
	public class Reservation
	{
		public Reservation(Guid id, Guid placeId, string personBooking, string placeName, DateTime date)
		{
			Id = id;
			PlaceId = placeId;
			PersonBooking = personBooking;
			ChangePlaceName(placeName);
			Date = date;
		}

		public Guid Id { get;}
		public Guid PlaceId { get; private set; }
		public string PersonBooking { get; private set; }
		public string PlaceName { get; private set; }
		public DateTime Date { get; private set; }

		public void ChangePlaceName(string placeName)
		{
			if (string.IsNullOrEmpty(placeName))
			{
				throw new EmptyPlaceException();
			}
		}
	}
}
