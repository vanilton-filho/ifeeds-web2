import 'package:flutter/material.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/avaliacao_model_request.dart';
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';
import 'package:ifeeds_app/services/campus_service.dart';
import 'package:ifeeds_app/services/categoria_service.dart';

class ExpansionTileAppWidget extends StatefulWidget {
  final IconData? leadingIcon;
  final String title;

  const ExpansionTileAppWidget({
    Key? key,
    this.leadingIcon,
    required this.title,
  }) : super(key: key);

  @override
  _ExpansionTileAppWidgetState createState() => _ExpansionTileAppWidgetState();
}

class _ExpansionTileAppWidgetState extends State<ExpansionTileAppWidget> {
  List<CategoriaModel>? _categorias;
  List<CampusModel>? _campus;
  List<AvaliacaoModel>? _avaliacoes;
  final _formKey = GlobalKey<FormState>();
  final _avaliacaoRequest = AvaliacaoModelRequest();

  @override
  void initState() {
    super.initState();
    _getCategorias();
    _getCampus();
    _getAvaliacoes();
  }

  _getCategorias() async {
    _categorias = await CategoriaService.listarCategorias();
  }

  _getCampus() async {
    _campus = await CampusService.listarCampus();
  }

  _getAvaliacoes() async {
    _avaliacoes = await AvaliacaoService.listarAvaliacoes();
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Builder(
        builder: (context) => Form(
          key: _formKey,
          child: Column(
            children: [
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Container(
                  child: Column(
                    children: [
                      Row(
                        children: [
                          Text(
                            widget.title,
                            style: TextStyle(fontSize: 23),
                          )
                        ],
                      ),
                      Divider(
                        thickness: 2,
                      ),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 12.0),
                        child: Row(
                          children: [
                            Expanded(
                                flex: 3,
                                child: FormFieldWidget(
                                  label: 'Nome da avaliação',
                                  onChanged: (value) =>
                                      _avaliacaoRequest.nome = value,
                                )),
                            Padding(
                                padding: EdgeInsets.symmetric(horizontal: 3)),
                            Expanded(
                              flex: 1,
                              child: DropdownButtonFormField(
                                validator: (val) => val == null
                                    ? 'Selecione a categoria'
                                    : null,
                                isDense: true,
                                autovalidateMode:
                                    AutovalidateMode.onUserInteraction,
                                decoration: const InputDecoration(
                                    border: OutlineInputBorder(),
                                    prefixIcon: Icon(Icons.account_circle),
                                    fillColor: Colors.white,
                                    focusColor: Colors.red),
                                hint: Text("Categoria"),
                                // isExpanded: true,
                                items: [
                                  ..._categorias!.map(
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
                            Padding(
                                padding: EdgeInsets.symmetric(horizontal: 3)),
                            Expanded(
                              flex: 1,
                              child: DropdownButtonFormField(
                                validator: (val) =>
                                    val == null ? 'Selecione o campus' : null,
                                isDense: true,
                                autovalidateMode:
                                    AutovalidateMode.onUserInteraction,
                                decoration: const InputDecoration(
                                    border: OutlineInputBorder(),
                                    prefixIcon: Icon(Icons.account_circle),
                                    fillColor: Colors.white,
                                    focusColor: Colors.red),
                                hint: Text("Campus"),
                                // isExpanded: true,
                                items: [
                                  ..._campus!.map(
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
                      Row(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: [
                          ButtonWidget(
                            edgeInsets: EdgeInsets.zero,
                            label: 'Adicionar +',
                            borderCircular: 15,
                            onPressed: () {
                              final form = _formKey.currentState;
                              if (form!.validate()) {}
                            },
                          ),
                        ],
                      ),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  _criarAvaliacao(AvaliacaoModelRequest request) async {
    var payload = request.toMap();
    await AvaliacaoService.criarAvaliacao(payload);
  }
}
