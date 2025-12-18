using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services
{
	public class CartEventService : BaseCRUDService<CartEventResponse, CartEventSearchObject, Database.CartEventIB190061, CartEventRequest, CartEventRequest>, ICartEventService
	{
		private readonly eCommerceDbContext _context;

		public CartEventService(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
		{
			_context = context;
		}

		public async Task<CartEventIB190061> AddCartEventAsync(int cartId, int? cartItemId, TipDogadjaja tipDogadjaja,int userId)
		{

			var cartEvent = new CartEventIB190061
			{
				CartId = cartId,
				CartItemId = cartItemId,
				TipDogadjaj = tipDogadjaja,
				UserId = userId,
				CreatedAt = System.DateTime.UtcNow
			};
			_context.Set<CartEventIB190061>().Add(cartEvent);
			await _context.SaveChangesAsync();
			return cartEvent;
		}
		
		
		protected override IQueryable<CartEventIB190061> ApplyFilter(IQueryable<CartEventIB190061> query, CartEventSearchObject search)
		{
			if (!string.IsNullOrEmpty(search.TipDogadjaj))
			{
				var tip = Enum.Parse<TipDogadjaja>(search.TipDogadjaj);
				query = query.Where(x => x.TipDogadjaj == tip);

			}
			if(search.UserId.HasValue)
			{
				query = query.Where(x => x.UserId == search.UserId.Value);
			}
			return query;
			
		}
		



	}
}
