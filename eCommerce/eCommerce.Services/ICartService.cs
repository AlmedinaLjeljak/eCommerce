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
	public interface ICartService : ICRUDService<CartResponse, BaseSearchObject, CartRequest, CartRequest>
	{
		Task<CartResponse> GetOrCreateCartResponse(int userId);
		Task<CartResponse> ClearCart(int userId);
		Task<CartResponse> ProceedToCheckout(int userId);

	}
}
