﻿using Reservations.Core.Entities;
using Reservations.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Infrastructure.Repositories
{
	internal class ReservationRepository : IReservationRepository
	{
		public void Add(Reservation reservation)
		{
			throw new NotImplementedException();
		}

		public void Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public Reservation Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Reservation> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Update(Reservation reservation)
		{
			throw new NotImplementedException();
		}
	}
}
