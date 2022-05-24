using System;
using HendonEventsAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HendonEventsAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EquipmentController : ControllerBase
	{
		private readonly IEquipmentRepository _equipmentRepository;
		public EquipmentController(IEquipmentRepository equipmentRepository)
		{
			_equipmentRepository = equipmentRepository;
		}

		[HttpGet]
		public IActionResult List()
        {
			return Ok(_equipmentRepository.All);
        }
	}
}

