import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/user/home/widgets/card_avaliacao_widget.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class ListCategoryWidget extends StatefulWidget {
  CategoriaModel? categoria;

  ListCategoryWidget({this.categoria});

  @override
  _ListCategoryWidgetState createState() => _ListCategoryWidgetState();
}

class _ListCategoryWidgetState extends State<ListCategoryWidget> {
  GetStorage storage = GetStorage();
  @override
  Widget build(BuildContext context) {
    return _buildCategory(context);
  }

  Widget _buildCategory(BuildContext context) {
    return FutureBuilder(
      future:
          _future(),
      builder: (context, AsyncSnapshot<dynamic> snapshot) {
        if (snapshot.hasData) {
          return _buildCategoryList(context, snapshot.data!);
        } else if (snapshot.hasError) {
          return Center(
            child: Text('Erro'),
          );
        }
        return Row(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            CircularProgressIndicator(),
          ],
        );
      },
    );
  }

  _future() async{
    if(JwtUtils.isExpired(storage)){
      RouterLogin.routeToLogin(context);
    }else {
      return await AvaliacaoService().listarAvaliacoesPorCategoria(widget.categoria!.id!);
    }
  }  

  _buildCategoryList(BuildContext contex, List<AvaliacaoModel> avaliacoes) {
    return Container(
      child: Column(
        children: [
          Align(
            alignment: Alignment.centerLeft,
            child: Padding(
              padding: const EdgeInsets.symmetric(horizontal: 21.0),
              child: Text(
                widget.categoria!.nome!,
                style: AppTextStyles.categoria,
              ),
            ),
          ),
          Divider(),
          Expanded(
            child: ListView(
              scrollDirection: Axis.horizontal,
              children: avaliacoes
                  .map((avaliacao) => CardAvaliacaoWidget(
                        avaliacaoModel: avaliacao,
                      ))
                  .toList(),
            ),
          ),
        ],
      ),
    );
  }
}
