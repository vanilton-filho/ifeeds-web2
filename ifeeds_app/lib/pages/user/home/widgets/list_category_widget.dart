import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/user/home/widgets/card_avaliacao_widget.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';

class ListCategoryWidget extends StatefulWidget {
  CategoriaModel? categoria;

  ListCategoryWidget({this.categoria});

  @override
  _ListCategoryWidgetState createState() => _ListCategoryWidgetState();
}

class _ListCategoryWidgetState extends State<ListCategoryWidget> {
  @override
  Widget build(BuildContext context) {
    return _buildCategory(context);
  }

  Widget _buildCategory(BuildContext context) {
    return FutureBuilder(
      future:
          AvaliacaoService.listarAvaliacoesPorCategoria(widget.categoria!.id!),
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
