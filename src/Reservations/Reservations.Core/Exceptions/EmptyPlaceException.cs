namespace Reservations.Core.Exceptions
{
	//dajemy seald by nie można było po tej klasie dziedziczyć
	public sealed class EmptyPlaceException : CustomException
	{
		public EmptyPlaceException() : base("Place is empty")
		{
		}
	}
}
