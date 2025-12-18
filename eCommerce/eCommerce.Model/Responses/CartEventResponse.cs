using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Responses
{
	public class CartEventResponse
	{
		public int Id { get; set; }
		public int? CartId { get; set; }

		public int? CartItemId { get; set; }

		public int? UserId { get; set; }

		public string? TipDogadjaj { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string? ProductName { get; set; }
		public decimal? ProductPrice { get; set; }
		public int? PreviousQuantity { get; set; }
		public int? NewQuantity { get; set; }
	}
}
