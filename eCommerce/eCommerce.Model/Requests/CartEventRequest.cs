using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.Requests
{
	public class CartEventRequest
	{
		public string TipDogadjaj { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string? ProductName { get; set; }
		public decimal? ProductPrice { get; set; }
		public int? PreviousQuantity { get; set; }
		public int? NewQuantity { get; set; }
	}
}
