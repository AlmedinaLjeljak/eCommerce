import 'package:ecommerce_mobile/model/cartEvent.dart';
import 'package:ecommerce_mobile/model/unit_of_measure.dart';
import 'package:ecommerce_mobile/providers/base_provider.dart';

class CartEventProvider extends BaseProvider<CartEvent> {
  CartEventProvider() : super("cartEvent");

  @override
  CartEvent fromJson(dynamic json) {
    return CartEvent.fromJson(json);
  }
}
