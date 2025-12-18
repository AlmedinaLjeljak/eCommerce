using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services.Database
{
	public enum TipDogadjaja
	{
		AddProduct,
		RemoveProduct,
		ChangeQuantity,
		ClearCart,
		Checkout
	}
	public class CartEventIB190061
	{
		public int Id { get; set; }
		public int? CartId { get; set; }
		[ForeignKey("CartId")]
	
		public Cart? Cart { get; set; }
		public int? CartItemId { get; set; }
		[ForeignKey("CartItemId")]
		public CartItem? CartItem { get; set; }
		public int? UserId { get; set;}
		[ForeignKey("UserId")]
		public User? User { get; set; }
		public TipDogadjaja? TipDogadjaj { get; set; } = TipDogadjaja.AddProduct;
		public DateTime? CreatedAt { get; set; }
		public string? ProductName { get; set; }
		public decimal? ProductPrice { get; set; }
		public int? PreviousQuantity { get; set; }
		public int? NewQuantity { get; set; }

	}
}
