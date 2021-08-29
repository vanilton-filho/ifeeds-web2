import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';

class ExpansionTileWidget extends StatelessWidget {
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
  Widget build(BuildContext context) {
    return ExpansionTile(
      leading: Icon(
        leadingIcon,
      ),
      title: Text(
        title,
        style: AppTextStyles.normal2,
      ),
      children: [
        ...lista.map(
          (e) => ListTile(
            dense: true,
            title: Text(
              isAvaliacao ? e.titulo! : e.nome!,
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
                            content: Text(isAvaliacao ? e.titulo! : e.nome!),
                            actions: <Widget>[
                              ButtonWidget(
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
}
