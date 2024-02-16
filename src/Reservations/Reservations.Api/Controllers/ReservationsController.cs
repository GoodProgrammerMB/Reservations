using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservations.Application.Commands;
using Reservations.Application.DTO;
using Reservations.Application.Services;
using System.Windows.Input;

namespace Reservations.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReservationsController : ControllerBase
	{
		private ReservationService _reservationService;

		public ReservationsController(ReservationService reservationService)
		{
			_reservationService = reservationService;
		}

		[HttpGet("{id:guid}")]
		public ActionResult<ReservationDto>	Get(Guid id)
		{
			var reservation = _reservationService.Get(id);
			if(reservation is null)
			{
				return NotFound();
			}
			return Ok(reservation);
		}

		[HttpGet]
		public ActionResult<IEnumerable<Application.DTO.ReservationDto>> GetAll() 
		{
			return Ok();
		}

		[HttpPost]
		public ActionResult Create(CreateReservation comand) 
		{
			var createdId = _reservationService.Create(comand with { ReservationId = Guid.NewGuid() });
			if(createdId is null)
			{
				return BadRequest();
			}

			return CreatedAtAction(nameof(Get),new { createdId }, null);
		}

		[HttpPut("{id:guid}")]
		public ActionResult Update(Guid id, ChangeReservation comand)
		{
			if (_reservationService.Update(comand with { ReservationId = id }))
			{
				return NoContent();
			}
			return NotFound();
		}

		[HttpDelete("{id:guid}")]
		public ActionResult Delete(Guid id)
		{
			if (_reservationService.Delete(id))
			{
				return NoContent();
			}
			return NotFound();
		}

		[HttpPatch]
		public ActionResult UpadtePlace()
		{
			return NoContent();
		}
	}
}
