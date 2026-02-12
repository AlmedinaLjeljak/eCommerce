import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cartEvent.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/cartEvent_provider.dart';
import 'package:ecommerce_mobile/providers/cartModel_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/product_details_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';

class CartEventScreenVjezba extends StatefulWidget {
  const CartEventScreenVjezba({super.key});

  @override
  State<CartEventScreenVjezba> createState() => _CartEventScreenState();
}

class _CartEventScreenState extends State<CartEventScreenVjezba> {
  late CartEventProvider cartEventProvider;
 

  TextEditingController searchController = TextEditingController();

  SearchResult<CartEvent>? data;
  SearchResult<CartEvent>? alldata;



  @override
  void initState() {
    super.initState();
    cartEventProvider = context.read<CartEventProvider>();
   
    loadData();
  }

  void loadData() async {
    var result = await cartEventProvider.get();
    data = result;
    alldata=result;
    setState(() {});
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Cart Event List",
      child: Center(
        child: Column(
          children: [
            //_buildSearch(),
            Expanded(child:_buildResultView() )
            
          ],
        ),
      ),
    );
  }
  
  Widget _buildResultView()
  {
    if(data==null){
      return const Center(child: CircularProgressIndicator(),);
    }
    if(data!.items==null || data!.items!.isEmpty){
      return const Center(child: Text("No data"),);
    }

    return ListView.builder(
      itemCount: data!.items!.length,
      itemBuilder: (context,index){
        final e=data!.items![index];

        return Card(
          margin: const EdgeInsets.all(8),
          child: Padding(padding: const EdgeInsets.all(10),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text("Naziv: ${e.user?.firstName??""} ${e.user?.lastName??""}" ),
              Text("Tip dogadjaja: ${e.tipDogadjaj??""}"),
              Text("Proizvod: ${e.productName??""}"),
              Text("Datum: ${e.createdAt.toString().split(" ").first}")
            ],
          ),),
        );

      });
  }
  
  
  
  }