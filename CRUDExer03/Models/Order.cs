﻿using System;
namespace CRUDExer03.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime OrderDateTime { get; set; }
		public decimal TotalAmount { get; set; }
		public int CustomerId { get; set; }
		public OrderItem OrderItem { get; set; }
	}
}

