import 'package:ecommerce_mobile/model/cartModel.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cartItem.g.dart';

@JsonSerializable()
class CartItem {
  final int id;
  final int? quantity;
  final DateTime? addedAt;
  final DateTime? updatedAt;
  final int? cartId;
  final Cart? cart;
  final int? productId;
  final Product? product;

  CartItem({
    this.id = 0,
    this.quantity,
    this.addedAt,
    this.updatedAt,
    this.cartId,
    this.cart,
    this.productId,
    this.product
  });

  factory CartItem.fromJson(Map<String, dynamic> json) => _$CartItemFromJson(json);

  Map<String, dynamic> toJson() => _$CartItemToJson(this);
} 