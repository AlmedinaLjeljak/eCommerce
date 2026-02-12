// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cartEvent.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

CartEvent _$CartEventFromJson(Map<String, dynamic> json) => CartEvent(
      id: (json['id'] as num?)?.toInt() ?? 0,
      cartId: (json['cartId'] as num?)?.toInt(),
      cart: json['cart'] == null
          ? null
          : Cart.fromJson(json['cart'] as Map<String, dynamic>),
      cartItemId: (json['cartItemId'] as num?)?.toInt(),
      cartItem: json['cartItem'] == null
          ? null
          : CartItem.fromJson(json['cartItem'] as Map<String, dynamic>),
      userId: (json['userId'] as num?)?.toInt(),
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
      tipDogadjaj: json['tipDogadjaj'] as String?,
      createdAt: json['createdAt'] == null
          ? null
          : DateTime.parse(json['createdAt'] as String),
      productName: json['productName'] as String?,
      productPrice: (json['productPrice'] as num?)?.toDouble(),
      previousQuantity: (json['previousQuantity'] as num?)?.toInt(),
      newQuantity: (json['newQuantity'] as num?)?.toInt(),
    );

Map<String, dynamic> _$CartEventToJson(CartEvent instance) => <String, dynamic>{
      'id': instance.id,
      'cartId': instance.cartId,
      'cart': instance.cart,
      'cartItemId': instance.cartItemId,
      'cartItem': instance.cartItem,
      'userId': instance.userId,
      'user': instance.user,
      'tipDogadjaj': instance.tipDogadjaj,
      'createdAt': instance.createdAt?.toIso8601String(),
      'productName': instance.productName,
      'productPrice': instance.productPrice,
      'previousQuantity': instance.previousQuantity,
      'newQuantity': instance.newQuantity,
    };
