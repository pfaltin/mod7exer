using System;
namespace CRUDExer03.Models
{
	public class OrderItem
	{
		public int OrderItemId { get; set; }
		public int ProductId { get; set; }
		public decimal Quantity { get; set; }
		public decimal ItemPrice { get; set; }
		public decimal ItemsSubTotal { get; set; }
		// public int OrderId { get; set; }


	}
}

