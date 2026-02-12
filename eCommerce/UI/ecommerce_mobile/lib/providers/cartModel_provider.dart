import 'dart:convert';

import 'package:ecommerce_mobile/model/cartModel.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/model/unit_of_measure.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart';
import 'package:http/http.dart' as http;

class Cart_Provider extends BaseProvider<Cart> {
  Cart_Provider() : super("cart");

  Cart? cart;

  @override
  Cart fromJson(dynamic json) {
    return Cart.fromJson(json);
  }
  
 Future<void> addToCart(Product product) async {
    try {
      var request = {
        "productId": product.id,
        "quantity": 1,
      };

      // Poziv backend CreateAsync (CartItemService)
      await insert(request);

      // Nakon dodavanja, učitaj cijelu korpu
      await loadCart();

      notifyListeners();
    } catch (e) {
      debugPrint("ERROR addToCart: $e");
    }
  }
  Future<void> loadCart() async {
    try {
      // ovdje pozivamo BaseProvider.get
      SearchResult<Cart> result = await super.get(filter: {"userId": 1});

      cart = (result.items != null && result.items!.isNotEmpty) ? result.items![0] : null;
      notifyListeners();
    } catch (e) {
      debugPrint("ERROR loadCart: $e");
    }
  }






 Future Checkout(int id) async {
  String  _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "https://localhost:44311/api/");
    var url = "${_baseUrl}cart/checkout/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();
await http.patch(uri,headers:headers);

 }
  Future ClearCart(int id) async {
  String  _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "https://localhost:44311/api/");
    var url = "${_baseUrl}cart/clear/$id";
    var uri = Uri.parse(url);
    var headers = createHeaders();
await http.patch(uri,headers:headers);

 }


}
