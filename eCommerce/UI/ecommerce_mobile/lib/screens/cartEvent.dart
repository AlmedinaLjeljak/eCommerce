import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cartEvent.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/cartEvent_provider.dart';
import 'package:ecommerce_mobile/providers/cartItem_provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class CartEventProbaScreen extends StatefulWidget {
  const CartEventProbaScreen({super.key});

  @override
  State<CartEventProbaScreen> createState() => _CartEventScreenState();
}

class _CartEventScreenState extends State<CartEventProbaScreen> {
  late CartEventProvider cartEventProvider;
  TextEditingController userController = TextEditingController();
  TextEditingController tipController = TextEditingController();

 

  SearchResult<CartEvent>? data;

  @override
  void initState() {
    super.initState();
    cartEventProvider = context.read<CartEventProvider>();

    loadData();
  }

  Future<void> loadData() async {
    var result = await cartEventProvider.get();
    data = result;
    setState(() {});
  }


  @override
  Widget build(BuildContext context) {
    return MasterScreen(
      title: "Product List",
      child: Column(
        children: [
          _buildSearch(),
          Expanded(child: _buildResultView()),
        ],
      ),
    );
  }

Widget _buildSearch(){


    return Padding(
      padding: EdgeInsets.all(10),
      child: Row(
        children: [
          Expanded(
            child: TextField(
              controller: userController,
              decoration: InputDecoration(
                hintText: "Pretraga po korisniku",
                border: OutlineInputBorder(),
              ),
            ),
          ),
          SizedBox(width: 10),
           Expanded(
            child: TextField(
              controller: tipController,
              decoration: InputDecoration(
                hintText: "Pretraga po tipu",
                border: OutlineInputBorder(),
              ),
            ),
          ),
          SizedBox(width: 10),
          ElevatedButton(
            onPressed: () async {
             String userText=userController.text.toLowerCase();
             String tipText=tipController.text.toLowerCase();

             var result=await cartEventProvider.get();
             data=SearchResult<CartEvent>(
              items:result.items?.where((e){
                bool matchesUser= 
                (e.user?.firstName??"-").toLowerCase().contains(userText) ||
                (e.user?.lastName??"-").toLowerCase().contains(userText);
                bool matchesTip= 
                (e.tipDogadjaj??"-").toLowerCase().contains(tipText);


                return matchesUser && matchesTip;

              }).toList() );

              
              setState(() {
             
              });
            },
            child: Text("Search"),
          ),
        ],
      ),
    );



}




Widget _buildResultView(){
  if(data==null){
    return const Center(child: Text("No"),);
  }
  if(data!.items==null || data!.items!.isEmpty){
    return const Center(child: Text("No"),);
  }

  return ListView.builder(
    itemCount: data!.items!.length,
    itemBuilder: (context,index){
      final e=data!.items![index];
      return Card(
        margin: const EdgeInsets.all(8),
        child: ListTile(
          title: Text(
            e.user!=null ? 
            "${e.user?.firstName??"-"} ${e.user?.lastName}"
            :"Nepoznat korisnik"
          ),
          subtitle: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text("Tip dogadjaja: ${e.tipDogadjaj??"-"}"),
              Text("Proizvod: ${e.productName??"-"}"),
              Text("Vrijeme: ${e.createdAt??"-"}")
            ],
          ),

        ),
      );

    });
  

}






}
