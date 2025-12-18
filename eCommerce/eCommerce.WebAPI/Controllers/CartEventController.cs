using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
	[AllowAnonymous]
	public class CartEventController : BaseCRUDController<CartEventResponse, CartEventSearchObject, CartEventRequest, CartEventRequest>
	{
		public CartEventController(ICartEventService service) : base(service)
		{
		}

		// Allow anonymous access to GET endpoints only
	
	}
	}
