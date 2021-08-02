import 'package:flutter/material.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/user/home/widgets/list_category_widget.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return StreamBuilder(
      stream: categoriasStream(),
      builder: (context, AsyncSnapshot<List<CategoriaModel>> snapshot) {
        if (snapshot.hasData) {
          List<CategoriaModel> categorias = snapshot.data!;
          return ListView(
            scrollDirection: Axis.vertical,
            shrinkWrap: true,
            itemExtent: 350,
            children: categorias
                .map((e) => ListCategoryWidget(
                      categoria: e,
                    ))
                .toList(),
          );
        } else if (snapshot.hasError) {
          return Center(
            child: Text('Erro'),
          );
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

  Stream<List<CategoriaModel>> categoriasStream() async* {
    while (true) {
      await Future.delayed(Duration(milliseconds: 1000));
      List<CategoriaModel> categorias =
          await AvaliacaoService.listarCategorias();
      yield categorias;
    }
  }
}
