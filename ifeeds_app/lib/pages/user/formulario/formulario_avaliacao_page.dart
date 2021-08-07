import 'package:flutter/material.dart';
import 'package:flutter_animator/flutter_animator.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model_request.dart';
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
      body: Container(
        padding: const EdgeInsets.symmetric(vertical: 16.0, horizontal: 16.0),
        child: Builder(
          builder: (context) => Form(
            key: _formKey,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.stretch,
              children: [
                FormFieldWidget(
                  edgeInsets: EdgeInsets.only(
                    left: 120,
                    right: 120,
                  ),
                  label: 'Título',
                  validator: (String? val) => (val!.isEmpty)
                      ? 'Por favor, insira a sua matrícula'
                      : null,
                  onChanged: (val) {
                    _formularioModel.titulo = val;
                  },
                ),
                Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: Text(
                    'Elogio/Reclamação',
                    style: GoogleFonts.roboto(fontSize: 24.0),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: ConstrainedBox(
                    constraints: BoxConstraints(maxHeight: 200),
                    child: TextFormField(
                      keyboardType: TextInputType.text,
                      controller: _descricao,
                      maxLines: 200,
                      decoration: InputDecoration(
                          border: OutlineInputBorder(),
                          hintText: "Forneça algum comentário!"),
                      validator: (String? val) => (val!.isEmpty)
                          ? 'Por favor, forneça algum comentário'
                          : null,
                    ),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 30.0),
                  child: Center(
                    child: Text(
                      '$_nota',
                      style: GoogleFonts.robotoCondensed(
                        fontSize: 33,
                        fontWeight: FontWeight.w400,
                      ),
                    ),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.all(12.0),
                  child: Center(
                    child: RatingBar.builder(
                      glowColor: Colors.transparent,
                      itemSize: 42.0,
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
                ),
                Expanded(child: Padding(padding: EdgeInsets.zero)),
                Container(
                  padding: const EdgeInsets.only(top: 5.0, bottom: 5.0),
                  child: ElevatedButton(
                    onPressed: () {
                      final form = _formKey.currentState;
                      if (form!.validate()) {
                        _formularioModel.descricao = _descricao.text;
                        _formularioModel.nota = _nota;
                        print(_formularioModel.toMap());
                        _salvarFormulario(_formularioModel);
                      }
                    },
                    child: Text(
                      'Enviar',
                      style: GoogleFonts.sourceSansPro(
                        fontSize: 21.0,
                        fontWeight: FontWeight.w600,
                        color: Colors.white,
                      ),
                    ),
                    style: ButtonStyle(
                      padding: MaterialStateProperty.all<EdgeInsets>(
                          const EdgeInsets.all(8.0)),
                      foregroundColor: MaterialStateProperty.all<Color>(
                        Colors.green,
                      ),
                      backgroundColor: MaterialStateProperty.all<Color>(
                        Colors.green,
                      ),

                      // shape: MaterialStateProperty.all<
                      //     RoundedRectangleBorder>(
                      //   RoundedRectangleBorder(
                      //     borderRadius: BorderRadius.circular(18.0),
                      //   ),
                      // ),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
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
