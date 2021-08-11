import 'dart:html';

import 'package:flutter/material.dart';
import 'package:flutter_animator/flutter_animator.dart';
import 'package:flutter_breadcrumb/flutter_breadcrumb.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model_request.dart';
import 'package:ifeeds_app/pages/login/widgets/page_view_widget.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/services/formulario_service.dart';

class FormularioAvaliacaoPage extends StatefulWidget {
  const FormularioAvaliacaoPage({Key? key}) : super(key: key);

  @override
  _FormularioAvaliacaoPageState createState() =>
      _FormularioAvaliacaoPageState();
}

class _FormularioAvaliacaoPageState extends State<FormularioAvaliacaoPage> {
  final _formKey = GlobalKey<FormState>();
  final _formularioModel = FormularioAvaliacaoModelRequest();
  final _descricao = TextEditingController();
  double _nota = 0.0;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(bottom: PreferredSize(
            preferredSize: Size.fromHeight(80.0),
            child: Container(
              color: Colors.white,
              height: 80.0,
              child: Padding(
                padding: const EdgeInsets.symmetric(
                    vertical: 29.0 / 2, horizontal: 19.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    BreadCrumb(
                    items: <BreadCrumbItem>[
                    BreadCrumbItem(content: Text('Realizar Feedback', style: GoogleFonts.titilliumWeb(fontSize: 22.0, fontWeight: FontWeight.bold),)),
	            ],
	            divider: Icon(Icons.chevron_right),)
                  ],
                ),
              ),
            ),
          ),),
      body: Row(
        children: [
          Expanded(
            child: Container(
              
              padding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 16.0),
              child: Builder(
                builder: (context) => Form(
                  key: _formKey,
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.stretch,
                    children: [
                      Expanded(child: SizedBox()),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8.0),
                        child: FormFieldWidget(
                          edgeInsets: EdgeInsets.only(
                            left: 0,
                            right: 0,
                          ),
                          label: 'Título',
                          validator: (String? val) => (val!.isEmpty)
                              ? 'Por favor, insira a sua matrícula'
                              : null,
                          onChanged: (val) {
                            _formularioModel.titulo = val;
                          },
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8.0),
                        child: ConstrainedBox(
                          constraints: BoxConstraints(maxHeight: 200),
                          child: TextFormField(
                            textAlignVertical: TextAlignVertical.top,
                            keyboardType: TextInputType.text,
                            controller: _descricao,
                            maxLines: 200,
                            decoration: InputDecoration(
                                labelText: "Descrição",
                                alignLabelWithHint: true,
                                border: OutlineInputBorder(),
                                hintText:
                                    "Forneça um comentário, dúvida, elogio ou sugestão!"),
                            validator: (String? val) => (val!.isEmpty)
                                ? 'Por favor, forneça algum comentário'
                                : null,
                          ),
                        ),
                      ),
                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8.0),
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Text("Nota", style: GoogleFonts.titilliumWeb(fontSize: 26.0),), 
                            Padding(
                              padding: const EdgeInsets.symmetric(horizontal: 8.0),
                              child: RatingBar.builder(
                                glowColor: Colors.transparent,
                                itemSize: 34.0,
                                initialRating: 0,
                                minRating: 0,
                                maxRating: 5,
                                direction: Axis.horizontal,
                                allowHalfRating: true,
                                itemCount: 5,
                                itemPadding: EdgeInsets.symmetric(horizontal: 4.0),
                                itemBuilder: (context, _) => Icon(
                                  Icons.star_rounded,
                                  color: Colors.amber,
                                ),
                                onRatingUpdate: (double value) {
                                  setState(() {
                                    _nota = value;
                                  });
                                },
                                updateOnDrag: true,
                              ),
                            ),
                            Text(
                              '${_nota.toStringAsFixed(1)}',
                              style: GoogleFonts.robotoCondensed(
                                fontSize: 30,
                                fontWeight: FontWeight.w400,
                              ),
                            ),
                          ],
                        ),
                      ),

                      Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8.0),
                        child: ButtonWidget(edgeInsets: EdgeInsets.symmetric(vertical: 12.0), label: 'Realizar Feedback', borderCircular: 8.0, buttonStyle: AppButtonStyles.green, onPressed: () {
                              final form = _formKey.currentState;
                              if (form!.validate()) {
                                _formularioModel.descricao = _descricao.text;
                                _formularioModel.nota = _nota;
                                print(_formularioModel.toMap());
                                _salvarFormulario(_formularioModel);
                              }
                            },),
                      ),
                      Expanded(child: SizedBox()),
                    ],
                  ),
                ),
              ),
            ),
          ),
        Expanded(
          child: Container(child: PageViewWidget(totalPages: 1, images: [Image.asset('assets/feedback.jpg')],),) ,
          

        )
        ,
        ],
      ),
    );
  }

  _salvarFormulario(FormularioAvaliacaoModelRequest formulario) async {
    var formularioSalvo =
        await FormularioService.postFormulario(formulario.toMap());
    print(formularioSalvo);
    await showModalBottomSheet(
        context: context,
        builder: (context) {
          return Container(
            height: 300,
            child: Padding(
              padding: const EdgeInsets.only(top: 42.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  HeartBeat(
                    preferences: AnimationPreferences(
                      duration: Duration(seconds: 2),
                    ),
                    child: Padding(
                      padding: const EdgeInsets.all(8.0),
                      child: Icon(
                        Icons.star_rounded,
                        color: Colors.amber,
                        size: 100.0,
                      ),
                    ),
                  ),
                  BounceInUp(
                    preferences:
                        AnimationPreferences(duration: Duration(seconds: 2)),
                    child: Text(
                      'Obrigado pelo feedback!',
                      style: GoogleFonts.roboto(
                        fontSize: 23.0,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.all(12.0),
                    child: Wrap(
                      children: [
                        Text(
                          '',
                          style: GoogleFonts.roboto(fontSize: 16.0),
                          textAlign: TextAlign.center,
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          );
        },
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.only(
              topLeft: Radius.circular(42.0), topRight: Radius.circular(42.0)),
        ));
  }
}
