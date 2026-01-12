using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
	public class CartController : BaseCRUDController<CartResponse, BaseSearchObject, CartRequest, CartRequest>
	{
		new ICartService _service;

		public CartController(ICartService service) : base(service)
		{
			_service = service;
		}
		[HttpGet("user/{userId}")]
		public async Task<IActionResult> GetOrCreate(int userId)
		{
			// Ovdje zovemo metodu koja vraća CartResponse, a ne EF entitet
			var cart = await _service.GetOrCreateCartResponse(userId);
			return Ok(cart);
		}

		[HttpPost("user/{userId}/clear")]
		public async Task<IActionResult> ClearCart(int userId)
		{
			var cart = await _service.ClearCart(userId);
			return Ok(cart);
		}

		// Proceed to checkout
		[HttpPost("user/{userId}/checkout")]
		public async Task<IActionResult> ProceedToCheckout(int userId)
		{
			var cart = await _service.ProceedToCheckout(userId);
			return Ok(cart);
		}

	}
}
