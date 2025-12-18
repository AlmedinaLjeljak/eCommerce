using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Authorization;

namespace eCommerce.WebAPI.Controllers
{
	[AllowAnonymous]
	public class CartItemController : BaseCRUDController<CartItemResponse, CartItemSearchObject, CartItemRequest, CartItemRequest>
	{
		public CartItemController(ICartItemService service) : base(service)
		{
		}

		// Allow anonymous access to GET endpoints only

	}
}
