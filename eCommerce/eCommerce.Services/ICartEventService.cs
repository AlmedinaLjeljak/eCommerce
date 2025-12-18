using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services
{
	public interface ICartEventService : ICRUDService<CartEventResponse, CartEventSearchObject, CartEventRequest, CartEventRequest>
	{
		Task<CartEventIB190061> AddCartEventAsync(int cartId, int? cartItemId, TipDogadjaja tipDogadjaj, int userId);
	}
}
