import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/avaliacao_model_request.dart';
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/models/campus_model_request.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/models/categoria_model_request.dart';
import 'package:ifeeds_app/pages/user/admin/widgets/expansion_tile_widget.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/services/avaliacao_service.dart';
import 'package:ifeeds_app/services/campus_service.dart';
import 'package:ifeeds_app/services/categoria_service.dart';

class AcoesPage extends StatefulWidget {
  final IconData? leadingIcon;

  const AcoesPage({
    Key? key,
    this.leadingIcon,
  }) : super(key: key);

  @override
  _AcoesPageState createState() => _AcoesPageState();
}

class _AcoesPageState extends State<AcoesPage> {
  late List<CategoriaModel>? _categorias;
  late List<CampusModel>? _campus;
  late List<AvaliacaoModel>? _avaliacoes;
  final _formKey = GlobalKey<FormState>();
  final _avaliacaoRequest = AvaliacaoModelRequest();
  final _categoriaRequest = CategoriaModelRequest();
  final _campusRequest = CampusModelRequest();
  final _formKey2 = GlobalKey<FormState>();
  final _formKey3 = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _getCategorias();
    _getCampus();
    _getAvaliacoes();
  }

  _getCategorias() async {
    _categorias = await CategoriaService.listarCategorias();
    setState(() {});
  }

  _getCampus() async {
    _campus = await CampusService.listarCampus();
    setState(() {});
  }

  _getAvaliacoes() async {
    _avaliacoes = await AvaliacaoService.listarAvaliacoes();
    setState(() {});
  }

  _stream() async* {
    while (true) {
      await Future.delayed(Duration(milliseconds: 5000));
      if (_avaliacoes != null && _categorias != null && _campus != null) {
        _categorias = await CategoriaService.listarCategorias();
        _campus = await CampusService.listarCampus();
        _avaliacoes = await AvaliacaoService.listarAvaliacoes();
        yield true;
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    return StreamBuilder(
        stream: _stream(),
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            return Container(
              child: ListView(
                children: [
                  Column(
                    children: [
                      Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: Builder(
                          builder: (context) => Form(
                            key: _formKey,
                            child: Column(
                              children: [
                                Row(
                                  children: [
                                    Text(
                                      'Avaliações',
                                      style: AppTextStyles.heading2,
                                    )
                                  ],
                                ),
                                Divider(
                                  thickness: 2,
                                ),
                                Padding(
                                  padding: const EdgeInsets.symmetric(
                                      vertical: 12.0),
                                  child: Row(
                                    children: [
                                      Expanded(
                                          flex: 3,
                                          child: FormFieldWidget(
                                            label: 'Nome da avaliação',
                                            validator: (value) => value!.isEmpty
                                                ? "Por favor, forneça um título para a avaliação"
                                                : null,
                                            onChanged: (value) =>
                                                _avaliacaoRequest.titulo =
                                                    value,
                                          )),
                                      Padding(
                                          padding: EdgeInsets.symmetric(
                                              horizontal: 3)),
                                      Expanded(
                                        flex: 1,
                                        child: DropdownButtonFormField(
                                          validator: (val) => val == null
                                              ? 'Selecione a categoria'
                                              : null,
                                          isDense: true,
                                          autovalidateMode: AutovalidateMode
                                              .onUserInteraction,
                                          decoration: const InputDecoration(
                                              border: OutlineInputBorder(),
                                              prefixIcon:
                                                  Icon(Icons.account_circle),
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
                                              _avaliacaoRequest.categoriaId =
                                                  val;
                                            });
                                          },
                                        ),
                                      ),
                                      Padding(
                                          padding: EdgeInsets.symmetric(
                                              horizontal: 3)),
                                      Expanded(
                                        flex: 1,
                                        child: DropdownButtonFormField(
                                          validator: (val) => val == null
                                              ? 'Selecione o campus'
                                              : null,
                                          isDense: true,
                                          autovalidateMode: AutovalidateMode
                                              .onUserInteraction,
                                          decoration: const InputDecoration(
                                              border: OutlineInputBorder(),
                                              prefixIcon:
                                                  Icon(Icons.account_circle),
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
                                      buttonStyle: AppButtonStyles.green,
                                      label: 'Adicionar +',
                                      borderCircular: 15,
                                      onPressed: () {
                                        final form = _formKey.currentState;
                                        if (form!.validate()) {
                                          _criarAvaliacao(_avaliacaoRequest);
                                        }
                                      },
                                    ),
                                  ],
                                ),
                              ],
                            ),
                          ),
                        ),
                      ),
                      ExpansionTileWidget(
                          leadingIcon: Icons.star,
                          lista: _avaliacoes!,
                          title: "Avaliações")
                    ],
                  ),
                  Builder(
                    builder: (context) => Form(
                      key: _formKey2,
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
                                        "Categorias",
                                        style: AppTextStyles.heading2,
                                      )
                                    ],
                                  ),
                                  Divider(
                                    thickness: 2,
                                  ),
                                  Padding(
                                    padding: const EdgeInsets.symmetric(
                                        vertical: 12.0),
                                    child: Row(
                                      children: [
                                        Expanded(
                                            flex: 3,
                                            child: FormFieldWidget(
                                              label: 'Nome da categoria',
                                              validator: (value) => value!
                                                      .isEmpty
                                                  ? "Por favor, forneça um nome para a categoria"
                                                  : null,
                                              onChanged: (value) =>
                                                  _categoriaRequest.nome =
                                                      value,
                                            )),
                                      ],
                                    ),
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.end,
                                    children: [
                                      ButtonWidget(
                                        edgeInsets: EdgeInsets.zero,
                                        buttonStyle: AppButtonStyles.green,
                                        label: 'Adicionar +',
                                        borderCircular: 15,
                                        onPressed: () {
                                          final form = _formKey2.currentState;
                                          if (form!.validate()) {
                                            _criarCategoria(_categoriaRequest);
                                          }
                                        },
                                      ),
                                    ],
                                  ),
                                ],
                              ),
                            ),
                          ),
                          ExpansionTileWidget(
                            leadingIcon: Icons.category,
                            lista: _categorias!,
                            title: "Categorias",
                            isAvaliacao: false,
                          )
                        ],
                      ),
                    ),
                  ),
                  Builder(
                    builder: (context) => Form(
                      key: _formKey3,
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
                                        "Campus",
                                        style: AppTextStyles.heading2,
                                      )
                                    ],
                                  ),
                                  Divider(
                                    thickness: 2,
                                  ),
                                  Padding(
                                    padding: const EdgeInsets.symmetric(
                                        vertical: 12.0),
                                    child: Row(
                                      children: [
                                        Expanded(
                                            flex: 3,
                                            child: FormFieldWidget(
                                              label: 'Nome de campus',
                                              validator: (value) => value!
                                                      .isEmpty
                                                  ? "Por favor, forneça um nome para o campus"
                                                  : null,
                                              onChanged: (value) =>
                                                  _campusRequest.nome = value,
                                            )),
                                      ],
                                    ),
                                  ),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.end,
                                    children: [
                                      ButtonWidget(
                                        buttonStyle: AppButtonStyles.green,
                                        edgeInsets: EdgeInsets.zero,
                                        label: 'Adicionar +',
                                        borderCircular: 15,
                                        onPressed: () {
                                          final form = _formKey3.currentState;
                                          if (form!.validate()) {
                                            _criarCampus(_campusRequest);
                                          }
                                        },
                                      ),
                                    ],
                                  ),
                                ],
                              ),
                            ),
                          ),
                          ExpansionTileWidget(
                            leadingIcon: Icons.school,
                            lista: _campus!,
                            title: "Campus",
                            isAvaliacao: false,
                          )
                        ],
                      ),
                    ),
                  ),
                ],
              ),
            );
          } else
            return Center(child: CircularProgressIndicator());
        });
  }

  _criarAvaliacao(AvaliacaoModelRequest request) async {
    var payload = request.toMap();
    print(await AvaliacaoService.criarAvaliacao(payload));
  }

  _criarCategoria(CategoriaModelRequest request) async {
    var payload = request.toMap();
    print(await CategoriaService.criarCategoria(payload));
  }

  _criarCampus(CampusModelRequest request) async {
    var payload = request.toMap();
    print(await CampusService.criarCampus(payload));
  }
}
