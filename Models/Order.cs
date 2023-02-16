using System;
using System.ComponentModel.DataAnnotations;

namespace Baileys_Order_API.Models
{
	public class Order
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public int InvoiceNumber { get; set; }

		[Required]
		[MaxLength(256)]
		public string Name { get; set; }

		[Required]
		[MaxLength(512)]
		public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

		[MaxLength(50)]
		public string Date { get; set; }
	}
}

