using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model.SearchObjects
{
	public class CartEventSearchObject:BaseSearchObject
	{
		public string? TipDogadjaj { get; set; }
		public int? UserId { get; set; }
		public UserSearchObject? User { get; set; }

	}
}
