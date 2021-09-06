import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/user/home/widgets/list_category_widget.dart';
import 'package:ifeeds_app/pages/widgets/error_app_widget.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/categoria_service.dart';

class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  GetStorage storage = GetStorage();

  @override
  Widget build(BuildContext context) {
    return StreamBuilder(
      stream: categoriasStream(),
      builder: (context, AsyncSnapshot<dynamic> snapshot) {
        if (snapshot.hasData) {
          List<CategoriaModel> categorias = snapshot.data!;
          return ListView(
            scrollDirection: Axis.vertical,
            shrinkWrap: true,
            itemExtent: 250,
            children: categorias
                .map((e) => ListCategoryWidget(
                      categoria: e,
                    ))
                .toList(),
          );
        } else if (snapshot.hasError) {
          return ErrorAppWidget(message: '${snapshot.error}');
        }
        return Center(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              CircularProgressIndicator(),
            ],
          ),
        );
      },
    );
  }

  categoriasStream() async* {
    while (true) {
      await Future.delayed(Duration(milliseconds: 5000));
      var categorias = await CategoriaService().listarCategorias();
      if (categorias == true) {
        RouterLogin.routeToLogin(context);
        break;
      }
      yield categorias;
    }
  }
}
