import 'package:flutter/material.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';

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
      ),
      children: [
        ...lista.map(
          (e) => ListTile(

            dense: true,
            title: Text(
              isAvaliacao?
              e.titulo!:
              e.nome!
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
                  onPressed: () => {},
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
