using System;
using HendonEventsAPI.Models;
using HendonEventsAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HendonEventsAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
    public class EquipmentController : ControllerBase
	{
		public enum ErrorCode
		{
			EquipmentInfoRequired,
			EquipmentIDInUse,
			RecordNotFound,
			CouldNotCreateItem,
			CouldNotUpdateItem,
			CouldNotDeleteItem
		}

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

		[HttpPost]
		public IActionResult Create([FromBody] Equipments item)
		{
			try
			{
				if (item == null || !ModelState.IsValid)
				{
					return BadRequest(ErrorCode.EquipmentInfoRequired.ToString());
				}
				bool itemExists = _equipmentRepository.DoesItemExist(item.ID);
				if (itemExists)
				{
					return StatusCode(StatusCodes.Status409Conflict, ErrorCode.EquipmentIDInUse.ToString());
				}
				_equipmentRepository.Insert(item);
			}
			catch (Exception)
			{
				return BadRequest(ErrorCode.CouldNotCreateItem.ToString());
			}
			return Ok(item);
		}

		[HttpPut]
		public IActionResult Edit([FromBody] Equipments item)
        {
            try
            {
				if (item == null || !ModelState.IsValid)
                {
					return BadRequest(ErrorCode.EquipmentInfoRequired.ToString());
                }
				var existingItem = _equipmentRepository.Find(item.ID);
				if (existingItem == null)
                {
					return NotFound(ErrorCode.RecordNotFound.ToString());
                }
				_equipmentRepository.Update(item);
            }

			catch (Exception)
            {
				return BadRequest(ErrorCode.CouldNotUpdateItem.ToString());
            }
			return NoContent();
        }
	}
}

