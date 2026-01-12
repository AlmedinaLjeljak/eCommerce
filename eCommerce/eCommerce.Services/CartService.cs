using MapsterMapper;
using System;
using System.Linq;
using System.Threading.Tasks;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
	public class CartService
		: BaseCRUDService<CartResponse, BaseSearchObject, Cart, CartRequest, CartRequest>, ICartService
	{
		private readonly eCommerceDbContext _db;
		private readonly ICartEventService _cartEventService;

		public CartService(eCommerceDbContext context, IMapper mapper,ICartEventService cartEventService)
			: base(context, mapper)
		{
			_db = context;
			_cartEventService = cartEventService;
		}

		
		public async Task<CartResponse> GetOrCreateCartResponse(int userId)
		{
			
			var cart = await _db.Carts
				.Include(c => c.CartItems)
				.ThenInclude(ci => ci.Product)
				.ThenInclude(p => p.Assets)
				.OrderByDescending(c => c.CreatedAt)
				.FirstOrDefaultAsync(c => c.UserId == userId);
			if (cart == null)
			{
				cart = new Cart
				{
					UserId = userId,
					CreatedAt = DateTime.UtcNow
				};

				_db.Carts.Add(cart);
				await _db.SaveChangesAsync();
			}
			return MapToResponse(cart);
		}

		
	
		public override async Task<CartResponse?> GetByIdAsync(int id)
		{
			var entity = await _db.Carts
				.Include(c => c.CartItems)
				.ThenInclude(ci => ci.Product)
				.ThenInclude(p => p.Assets)
				.FirstOrDefaultAsync(c => c.Id == id);

			if (entity == null) return null;

			return MapToResponse(entity);
		}

		public async Task<CartResponse> ClearCart(int userId)
		{
			var cart = await _db.Carts
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.UserId == userId);

			if (cart == null)
				throw new Exception("Cart not found");

			// Evidentiraj događaj za svaku stavku prije brisanja
			foreach (var item in cart.CartItems.ToList()) // ToList da ne mijenjamo kolekciju tokom iteracije
			{
				await _cartEventService.AddCartEventAsync(
					cart.Id,
					item.Id,
					TipDogadjaja.ClearCart,
					cart.UserId
				);

				_db.CartItems.Remove(item);
			}

			await _db.SaveChangesAsync();

			return MapToResponse(cart);
		}

		// Proceed to checkout – evidentira događaj za korpu, ne mjenja stavke
		public async Task<CartResponse> ProceedToCheckout(int userId)
		{
			var cart = await _db.Carts
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.UserId == userId);

			if (cart == null)
				throw new Exception("Cart not found");

			// Evidentiraj događaj Checkout
			await _cartEventService.AddCartEventAsync(
				cart.Id,
				null, // nema konkretne stavke
				TipDogadjaja.Checkout,
				cart.UserId
			);

			return MapToResponse(cart);
		}


	}
}
