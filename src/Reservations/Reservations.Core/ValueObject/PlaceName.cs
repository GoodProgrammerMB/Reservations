namespace Reservations.Core.ValueObject
{
	public record PlaceName
	{
		public PlaceName(string value)
		{
			Value = value;
		}

		public string Value { get; }
	}
}
