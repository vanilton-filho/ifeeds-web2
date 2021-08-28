import 'package:flutter/material.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';

class ExpansionTileWidget extends StatelessWidget {
  final IconData? leadingIcon;
  final String? title;
  final List<AvaliacaoModel> avaliacoes;

  const ExpansionTileWidget({
    Key? key,
    this.leadingIcon,
    this.title,
    required this.avaliacoes,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ExpansionTile(
      leading: Icon(
        leadingIcon,
      ),
      title: Text(
        title!,
      ),
      children: [
        ...avaliacoes.map(
          (e) => ListTile(
            dense: true,
            title: Text(
              e.titulo!,
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
