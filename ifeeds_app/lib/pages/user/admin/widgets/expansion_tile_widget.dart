import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';
import 'package:ifeeds_app/services/campus_service.dart';
import 'package:ifeeds_app/services/categoria_service.dart';

class ExpansionTileWidget extends StatefulWidget {
  final IconData? leadingIcon;
  final String title;
  final List<dynamic> lista;
  final isAvaliacao;

  const ExpansionTileWidget({
    Key? key,
    this.leadingIcon,
    required this.title,
    this.isAvaliacao = true,
    required this.lista,
  }) : super(key: key);

  @override
  _ExpansionTileWidgetState createState() => _ExpansionTileWidgetState();
}

class _ExpansionTileWidgetState extends State<ExpansionTileWidget> {
  @override
  Widget build(BuildContext context) {
    return ExpansionTile(
      leading: Icon(
        widget.leadingIcon,
      ),
      title: Text(
        widget.title,
        style: AppTextStyles.normal2,
      ),
      children: [
        ...widget.lista.map(
          (e) => ListTile(
            dense: true,
            title: Text(
              widget.isAvaliacao ? e.titulo! : e.nome!,
              style: AppTextStyles.tile,
            ),
            trailing: Wrap(
              children: [
                IconButton(
                    onPressed: () => {},
                    icon: Icon(
                      Icons.edit,
                      color: Colors.blue,
                    )),
                IconButton(
                  onPressed: () => {
                    showDialog(
                        context: context,
                        builder: (context) {
                          return AlertDialog(
                            title: Text('Tem certeza que deseja deletar?'),
                            content: Text(widget.isAvaliacao ? e.titulo! : e.nome!),
                            actions: <Widget>[
                              ButtonWidget(
                                onPressed: () => deletar(e),
                                buttonStyle: AppButtonStyles.delete,
                                edgeInsets: EdgeInsets.zero,
                                label: 'Remover',
                                borderCircular: 15,
                              )
                            ],
                          );
                        })
                  },
                  icon: Icon(
                    Icons.delete,
                    color: Colors.red,
                  ),
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  deletar(dynamic genericModel) async{
    if(genericModel is AvaliacaoModel){
      await AvaliacaoService.deletarAvaliacao(genericModel.id!);
    }else if (genericModel is CategoriaModel) {
      await CategoriaService.deletarCategoria(genericModel.id!);
    }else if (genericModel is CampusModel) {
      await CampusService.deletarCampus(genericModel.id!);
    }
    Navigator.pop(context);
  }
}


