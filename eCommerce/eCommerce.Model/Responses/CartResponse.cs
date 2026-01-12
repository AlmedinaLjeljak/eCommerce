using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
	public class CartResponse
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public UserResponse? User { get; set; }
		public string? SessionId { get; set; }
		public List<CartItemResponse>? CartItems { get; set; }
	}
}
