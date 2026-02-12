/*import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cartEvent.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/cartEvent_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/product_details_screen.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';

class CartEvenScreen extends StatefulWidget {
  const CartEvenScreen({super.key});

  @override
  State<CartEvenScreen> createState() => _CartEventScreenState();
}

class _CartEventScreenState extends State<CartEvenScreen> {
  late CartEventProvider cartEventProvider;

List<CartEvent> events=[];
bool isLoading=true;
String ? actionSearch;
String? userSearch;



  @override
  void initState() {
    super.initState();
    cartEventProvider=context.read<CartEventProvider>();
    _loadEvent();
  }

  void _loadEvent() async {
    final result = await cartEventProvider.get();
   
    setState(() {
      events=result.items?? [];
      isLoading=false;
    });
  }

@override
Widget build(BuildContext context) {
  return MasterScreen(
    title: "Event List",
    child: isLoading
        ? const Center(
            child: CircularProgressIndicator(),
          )
        : Column(
            children: [
              // SEARCH PO TIPU DOGAĐAJA
              Padding(
                padding: const EdgeInsets.all(12),
                child: TextField(
                  decoration: const InputDecoration(
                    labelText: "Pretraga po tipu događaja",
                    border: OutlineInputBorder(),
                  ),
                  onChanged: (value) {
                    setState(() {
                      actionSearch =
                          value.isEmpty ? null : value.toLowerCase();
                    });
                  },
                ),
              ),

              // SEARCH PO KORISNIKU
              Padding(
                padding: const EdgeInsets.all(12),
                child: TextField(
                  decoration: const InputDecoration(
                    labelText: "Pretraga po korisniku",
                    border: OutlineInputBorder(),
                  ),
                  onChanged: (value) {
                    setState(() {
                      userSearch = value.isEmpty ? null : value.toLowerCase();
                    });
                  },
                ),
              ),

              // LISTA DOGAĐAJA
              Expanded(
                child: ListView(
                  children: events
                      .where((e) {
                        // FILTER PO TIPU DOGAĐAJA
                        if (actionSearch != null) {
                          if (e.tipDogadjaj == null ||
                              !e.tipDogadjaj!
                                  .toLowerCase()
                                  .contains(actionSearch!)) {
                            return false;
                          }
                        }

                        // FILTER PO KORISNIKU
                        if (userSearch != null) {
                          final name = e.user != null
                              ? "${e.user!.firstName} ${e.user!.lastName}"
                                  .toLowerCase()
                              : "";
                          if (!name.contains(userSearch!)) return false;
                        }

                        return true;
                      })
                      .map((e) => _buildEventCard(e))
                      .toList(),
                ),
              ),
            ],
          ),
  );
}



 Widget _buildEventCard(CartEvent e) {
  final userName=e.user!=null
  ? "${e.user!.firstName} ${e.user!.lastName}"
  :"Nepoznat korisnik";

    return Card(
      margin: EdgeInsets.symmetric(horizontal: 16, vertical: 6),
      elevation: 3,
      child: ListTile(
        title: Text(
          e.tipDogadjaj ?? "",
          style: const TextStyle(fontWeight: FontWeight.bold),
        ),
        subtitle: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text("Korisnik: $userName"),
            if(e.productName!=null)
            Text("Proizvod: ${e.productName}"),
            if(e.productName!=null)
            Text("Cijena: ${e.productPrice} KM"),
            if(e.createdAt!=null)
            Text("Vrijeme: ${e.createdAt}")
          ],
        ),

        
      ),
    );
  }

}*/



import 'package:ecommerce_mobile/layouts/master_screen.dart';
import 'package:ecommerce_mobile/model/cartEvent.dart';
import 'package:ecommerce_mobile/model/cart_provider.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:ecommerce_mobile/model/search_result.dart';
import 'package:ecommerce_mobile/providers/cartEvent_provider.dart';
import 'package:ecommerce_mobile/providers/utils.dart';
import 'package:ecommerce_mobile/screens/product_details_screen.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';
import 'package:ecommerce_mobile/providers/product_provider.dart';

class CartEvenScreen extends StatefulWidget {
  const CartEvenScreen({super.key});

  @override
  State<CartEvenScreen> createState() => _CartEventScreenState();
}

class _CartEventScreenState extends State<CartEvenScreen> {
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
      title: "CartEvent List",
      child: Center(
        child: Column(
          children: [
            _buildSearch(),
            Expanded(child: _buildResultView()), // BITNO
          ],
        ),
      ),
    );
  }

 /* Widget _buildSearch() {
    return Padding(
      padding: const EdgeInsets.all(10),
      child: Row(
        children: [
          Expanded(
            child: TextField(
              controller: userController,
              decoration: const InputDecoration(
                hintText: "Pretraga po korisniku",
                border: OutlineInputBorder(),
              ),
            ),
          ),
          const SizedBox(width: 10),
          Expanded(
            child: TextField(
              controller: tipController,
              decoration: const InputDecoration(
                hintText: "Pretraga po tipu događaja",
                border: OutlineInputBorder(),
              ),
            ),
          ),
          const SizedBox(width: 10),
          ElevatedButton(
            onPressed: () async {
              String userText = userController.text.toLowerCase();
              String tipText = tipController.text.toLowerCase();

              var result = await cartEventProvider.get();

              data = SearchResult<CartEvent>(
                items: result.items?.where((e) {
                  bool matchesUser =
                      (e.user?.firstName ?? "").toLowerCase().contains(userText) ||
                      (e.user?.lastName ?? "").toLowerCase().contains(userText);

                  bool matchesTip =
                      (e.tipDogadjaj ?? "").toLowerCase().contains(tipText);

                  return matchesUser && matchesTip;
                }).toList(),
              );

              setState(() {});
            },
            child: const Text("Pretraži"),
          ),
        ],
      ),
    );
  }*/
   Widget _buildSearch() {
    return Padding(
        padding: EdgeInsets.all(10),
        child: Row(
          children: [
            Expanded(
              child: TextField(
                decoration: InputDecoration(
                  hintText: "Pretraga po korisniku",
                  border: OutlineInputBorder(),
                ),
                controller: userController,
              ),
            ),
            SizedBox(width: 10),
            Expanded(
              child: TextField(
                decoration: InputDecoration(
                  hintText: "Pretraga po tipu dogadjaja",
                  border: OutlineInputBorder(),
                ),
                controller: tipController,
              ),
            ),
            SizedBox(width: 10),
            ElevatedButton(
              onPressed: () async {
                String userText=userController.text.toLowerCase();
                String tipText=tipController.text.toLowerCase();

                var result=await cartEventProvider.get();
                data=SearchResult<CartEvent>(
                  items: result.items?.where((e){
                    bool matchesUser= 
                    (e.user?.firstName??"").toLowerCase().contains(userText)||
                    (e.user?.lastName??"").toLowerCase().contains(userText);

                    bool matchesTip= 
                    (e.tipDogadjaj??"").toLowerCase().contains(tipText);

                    return matchesUser && matchesTip;

                 

                  }).toList() ) ;              
                setState(() {});
              },
              child: Text("Search"),
            ),
            SizedBox(width: 10),
          ],
        ));
  }
  

Widget _buildResultView() {
  if (data == null) {
    return const Center(child: Text("No"));
  }

  if (data!.items == null || data!.items!.isEmpty) {
    return const Center(child: Text("No"));
  }

  return ListView.builder(
    itemCount: data!.items!.length,
    itemBuilder: (context, index) {
      final e = data!.items![index];

      return Card(
        margin: const EdgeInsets.all(8),
        child: ListTile(
          title: Text(
            e.user!=null ?
            "${e.user?.firstName ?? "-"} ${e.user?.lastName ?? "-"}"
            :"Nepoznat korisnik",
          ),
          subtitle: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Text("Tip događaja: ${e.tipDogadjaj ?? "-"}"),
              Text("Proizvod: ${e.productName ?? "-"}"),
              Text(
                "Vrijeme: ${e.createdAt != null
                    ? DateFormat('dd.MM.yyyy HH:mm').format(e.createdAt!)
                    : "-"}",
              ),
            ],
          ),
        ),
      );
    },
  );
}













 
}