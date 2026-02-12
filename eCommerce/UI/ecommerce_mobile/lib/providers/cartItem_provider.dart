import 'package:ecommerce_mobile/model/cartItem.dart';
import 'package:ecommerce_mobile/model/unit_of_measure.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class CartitemProvider extends BaseProvider<CartItem> {
  CartitemProvider() : super("cartItem");

  @override
  CartItem fromJson(dynamic json) {
    return CartItem.fromJson(json);
  }

    Future<void> addToCart(int cartId, int productId, int quantity) async {
    await insert({
      "cartId": cartId,
      "productId": productId,
      "quantity": quantity,
    });
  }

}
