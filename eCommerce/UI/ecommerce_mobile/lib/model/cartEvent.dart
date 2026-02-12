
import 'package:ecommerce_mobile/model/cartItem.dart';
import 'package:ecommerce_mobile/model/cartModel.dart' show Cart;
import 'package:ecommerce_mobile/model/user.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cartEvent.g.dart';

@JsonSerializable()
class CartEvent {
  final int id;
  final int? cartId;
  final Cart? cart;
  final int? cartItemId;
  final CartItem? cartItem;
  final int? userId;
  final User? user;
  final String? tipDogadjaj;
  final DateTime? createdAt;
  final String? productName;
  final double? productPrice;
  final int? previousQuantity;
  final int? newQuantity;


  CartEvent({
    this.id = 0,
    this.cartId,
    this.cart,
    this.cartItemId,
    this.cartItem,
    this.userId,
    this.user,
    this.tipDogadjaj,
    this.createdAt,
    this.productName,
    this.productPrice,
    this.previousQuantity,
    this.newQuantity
  });

  factory CartEvent.fromJson(Map<String, dynamic> json) => _$CartEventFromJson(json);

  Map<String, dynamic> toJson() => _$CartEventToJson(this);
} 