using MapsterMapper;
using System;
using System.Threading.Tasks;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;

namespace eCommerce.Services
{
	public class CartItemService
		: BaseCRUDService<CartItemResponse, CartItemSearchObject, CartItem, CartItemRequest, CartItemRequest>,
		  ICartItemService
	{
		private readonly ICartEventService _cartEventService;
		private readonly eCommerceDbContext _context;

		public CartItemService(
			eCommerceDbContext context,
			IMapper mapper,
			ICartEventService cartEventService)
			: base(context, mapper)
		{
			_context = context;
			_cartEventService = cartEventService;
		}

		
		public override async Task<CartItemResponse> CreateAsync(CartItemRequest request)
		{
			var entity = new CartItem();
			MapInsertToEntity(entity, request);

			_context.Set<CartItem>().Add(entity);
			await _context.SaveChangesAsync(); // Id generisan

			// logujemo događaj dodavanja proizvoda
			var cart = await _context.Carts.FindAsync(entity.CartId);
			if (cart != null)
			{
				await _cartEventService.AddCartEventAsync(
					entity.CartId,
					entity.Id, // sada je Id validan
					TipDogadjaja.AddProduct,
					cart.UserId
				);
			}

			return MapToResponse(entity);
		}

		// Prije brisanja logujemo događaj uklanjanja
		protected override async Task BeforeDelete(CartItem entity)
		{
			var cart = await _context.Carts.FindAsync(entity.CartId);
			if (cart == null)
				throw new Exception("Cart not found");

			await _cartEventService.AddCartEventAsync(
				entity.CartId,
				entity.Id,
				TipDogadjaja.RemoveProduct,
				cart.UserId
			);
		}
	}
}


