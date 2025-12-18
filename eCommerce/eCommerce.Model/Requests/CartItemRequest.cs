using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Requests
{
	public class CartItemRequest
	{
		public int Quantity { get; set; } = 1;
		public int CartId { get; set; }
		public int ProductId { get; set; }


	}
}
