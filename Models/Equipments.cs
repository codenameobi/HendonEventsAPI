using System;
using System.ComponentModel.DataAnnotations;

namespace HendonEventsAPI.Models
{
	public class Equipments
	{
		[Required]
		public string ID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		public bool Verfied { get; set; }
	}
}

