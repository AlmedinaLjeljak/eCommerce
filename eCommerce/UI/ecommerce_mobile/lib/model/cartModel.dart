
import 'package:ecommerce_mobile/model/cartItem.dart';
import 'package:ecommerce_mobile/model/user.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cartModel.g.dart';

@JsonSerializable()
class Cart {
  final int id;
  final int? userId;
  final User? user;
  final String? sessionId;
  final List<CartItem>? cartItems;

  

  Cart({
    this.id = 0,
    this.userId,
    this.user,
    this.sessionId,
    this.cartItems
  });

  factory Cart.fromJson(Map<String, dynamic> json) => _$CartFromJson(json);

  Map<String, dynamic> toJson() => _$CartToJson(this);
} 