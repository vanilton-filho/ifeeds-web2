import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/avaliacao_model_request.dart';
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/models/campus_model_request.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/models/categoria_model_request.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';
import 'package:ifeeds_app/services/campus_service.dart';
import 'package:ifeeds_app/services/categoria_service.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class ExpansionTileWidget extends StatefulWidget {
  final IconData? leadingIcon;
  final String title;
  final List<dynamic> lista;
  final isAvaliacao;
  final List<CampusModel>? campus;
  final List<CategoriaModel>? categorias;
  final int? campusId;
  final int? categoriaId;

  const ExpansionTileWidget(
      {Key? key,
      this.leadingIcon,
      required this.title,
      required this.lista,
      this.campus,
      this.categorias,
      this.isAvaliacao = true,
      this.campusId,
      this.categoriaId})
      : super(key: key);

  @override
  _ExpansionTileWidgetState createState() => _ExpansionTileWidgetState();
}

class _ExpansionTileWidgetState extends State<ExpansionTileWidget> {
  GetStorage storage = GetStorage();
  final _formKey = GlobalKey<FormState>();
  AvaliacaoModelRequest _avaliacaoRequest = AvaliacaoModelRequest();
  CategoriaModelRequest _categoriaRequest = CategoriaModelRequest();
  CampusModelRequest _campusRequest = CampusModelRequest();

  @override
  void initState() {
    setState(() {
      _avaliacaoRequest.campusId = widget.campusId;
      _avaliacaoRequest.categoriaId = widget.categoriaId;
    });
    super.initState();
  }

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
                  onPressed: () => {
                    showDialog(
                      context: context,
                      builder: (context) {
                        return AlertDialog(
                          title: Text('Alteração'),
                          content: _content(e),
                          actions: <Widget>[
                            ButtonWidget(
                              onPressed: () => atualizar(e),
                              buttonStyle: AppButtonStyles.atualizar,
                              edgeInsets: EdgeInsets.zero,
                              label: 'Atualizar',
                              borderCircular: 15,
                            )
                          ],
                        );
                      },
                    ),
                  },
                  icon: Icon(
                    Icons.edit,
                    color: Colors.blue,
                  ),
                ),
                IconButton(
                  onPressed: () => {
                    showDialog(
                        context: context,
                        builder: (context) {
                          return AlertDialog(
                            title: Text('Tem certeza que deseja deletar?'),
                            content:
                                Text(widget.isAvaliacao ? e.titulo! : e.nome!),
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

  _content(e) {
    if (e is AvaliacaoModel) {
      return _avaliacaoAtualizar(e);
    } else if (e is CategoriaModel) {
      return _atualizacaoCategoria(e);
    } else if (e is CampusModel) {
      return _atualizacaoCampus(e);
    }
  }

  _avaliacaoAtualizar(AvaliacaoModel e) {
    _avaliacaoRequest.titulo = e.titulo;
    _avaliacaoRequest.campusId = e.campus!.id;
    _avaliacaoRequest.categoriaId = e.categoria!.id;

    return Row(
      children: [
        Builder(
          builder: (context) => Form(
            key: _formKey,
            child: Expanded(
              flex: 3,
              child: Row(
                children: [
                  Expanded(
                    flex: 3,
                    child: FormFieldWidget(
                      initialValue: e.titulo!,
                      label: 'Nome da avaliação',
                      validator: (value) => value!.isEmpty
                          ? "Por favor, forneça um título para a avaliação"
                          : null,
                      onChanged: (value) => _avaliacaoRequest.titulo = value,
                    ),
                  ),
                  Padding(padding: EdgeInsets.symmetric(horizontal: 3)),
                  Expanded(
                    flex: 1,
                    child: DropdownButtonFormField(
                      validator: (val) =>
                          val == null ? 'Selecione a categoria' : null,
                      isDense: true,
                      autovalidateMode: AutovalidateMode.onUserInteraction,
                      decoration: const InputDecoration(
                          border: OutlineInputBorder(),
                          prefixIcon: Icon(Icons.account_circle),
                          fillColor: Colors.white,
                          focusColor: Colors.red),
                      hint: Text("${e.categoria!.nome}"),
                      // isExpanded: true,
                      items: [
                        ...widget.categorias!.map(
                          (e) => DropdownMenuItem<int>(
                            child: Text("${e.nome}"),
                            value: e.id,
                          ),
                        )
                      ],
                      onChanged: (int? val) {
                        setState(() {
                          _avaliacaoRequest.categoriaId = val;
                        });
                      },
                    ),
                  ),
                  Padding(padding: EdgeInsets.symmetric(horizontal: 3)),
                  Expanded(
                    flex: 1,
                    child: DropdownButtonFormField(
                      validator: (val) =>
                          val == null ? 'Selecione o campus' : null,
                      isDense: true,
                      autovalidateMode: AutovalidateMode.onUserInteraction,
                      decoration: const InputDecoration(
                          border: OutlineInputBorder(),
                          prefixIcon: Icon(Icons.account_circle),
                          fillColor: Colors.white,
                          focusColor: Colors.red),
                      hint: Text("${e.campus!.nome}"),
                      // isExpanded: true,
                      items: [
                        ...widget.campus!.map(
                          (e) => DropdownMenuItem<int>(
                            child: Text("${e.nome}"),
                            value: e.id,
                          ),
                        )
                      ],
                      onChanged: (int? val) {
                        setState(() {
                          _avaliacaoRequest.campusId = val;
                        });
                      },
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ],
    );
  }

  _atualizacaoCategoria(CategoriaModel e) {
    _categoriaRequest.nome = e.nome;

    return Row(
      children: [
        Builder(
          builder: (context) => Form(
            key: _formKey,
            child: Expanded(
              flex: 3,
              child: Row(
                children: [
                  Expanded(
                    child: FormFieldWidget(
                      initialValue: e.nome!,
                      label: 'Nome do campus',
                      validator: (value) => value!.isEmpty
                          ? "Por favor, forneça um nome para categoria"
                          : null,
                      onChanged: (value) => _categoriaRequest.nome = value,
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ],
    );
  }

  _atualizacaoCampus(CampusModel e) {
    _campusRequest.nome = e.nome;

    return Row(
      children: [
        Builder(
          builder: (context) => Form(
            key: _formKey,
            child: Expanded(
              flex: 3,
              child: Row(
                children: [
                  Expanded(
                    child: FormFieldWidget(
                      initialValue: e.nome!,
                      label: 'Nome do campus',
                      validator: (value) => value!.isEmpty
                          ? "Por favor, forneça um nome para campus"
                          : null,
                      onChanged: (value) => _campusRequest.nome = value,
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ],
    );
  }

  deletar(dynamic genericModel) async {
    if (JwtUtils.isExpired(storage)) {
      RouterLogin.routeToLogin(context);
    } else {
      if (genericModel is AvaliacaoModel) {
        await AvaliacaoService().deletarAvaliacao(genericModel.id!);
      } else if (genericModel is CategoriaModel) {
        await CategoriaService().deletarCategoria(genericModel.id!);
      } else if (genericModel is CampusModel) {
        await CampusService().deletarCampus(genericModel.id!);
      }
      Navigator.pop(context);
    }
  }

  atualizar(dynamic genericModel) async {
    if (JwtUtils.isExpired(storage)) {
      RouterLogin.routeToLogin(context);
    } else {
      if (genericModel is AvaliacaoModel) {
        var payload = _avaliacaoRequest;
        await AvaliacaoService()
            .atualizarAvaliacao(genericModel.id!, payload.toMap());
      } else if (genericModel is CategoriaModel) {
        var payload = _categoriaRequest;
        await CategoriaService()
            .atualizarCategoria(genericModel.id!, payload.toMap());
      } else {
        var payload = _campusRequest;
        await CampusService()
            .atualizarCampus(genericModel.id!, payload.toMap());
      }
      Navigator.pop(context);
    }
  }
}
