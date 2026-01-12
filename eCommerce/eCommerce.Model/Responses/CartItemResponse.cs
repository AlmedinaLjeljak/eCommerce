using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
	public class CartItemResponse
	{
		public int Id { get; set; }
		public int Quantity { get; set; } 

		public DateTime AddedAt { get; set; } = DateTime.UtcNow;

		public DateTime? UpdatedAt { get; set; }

	

		// Product in the cart
		public int ProductId { get; set; }
		public ProductResponse? Product { get; set; }

	
	}
}
