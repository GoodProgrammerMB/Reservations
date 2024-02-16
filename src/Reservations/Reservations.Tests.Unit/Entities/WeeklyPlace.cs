namespace Reservations.Api.Entities
{
	public class WeeklyPlace
	{
		private readonly HashSet<Reservation> _reservations = new();
		public Guid Id { get;}
		public DateTime From { get;}
		public DateTime To { get;}
		public string Name { get;}
		public IEnumerable<Reservation> Reservations => _reservations;

		public WeeklyPlace(Guid id, DateTime from, DateTime to, string name)
		{
			Id = id;
			From = from;
			To = to;
			Name = name;
		}
	}
}
