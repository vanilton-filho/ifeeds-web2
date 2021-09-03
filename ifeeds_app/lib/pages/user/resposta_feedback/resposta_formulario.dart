import 'package:flutter/material.dart';
import 'package:flutter_breadcrumb/flutter_breadcrumb.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:get_storage/get_storage.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/models/resposta_feedback_model.dart';
import 'package:ifeeds_app/models/resposta_feedback_model_request.dart';
import 'package:ifeeds_app/pages/login/widgets/page_view_widget.dart';
import 'package:ifeeds_app/pages/user/resposta_feedback/resposta_feedback_page.dart';
import 'package:ifeeds_app/pages/utils/snackbar_utils.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/services/feedback_service.dart';
import 'package:ifeeds_app/services/resposta_feedback_service.dart';

class RespostaFormulario extends StatefulWidget {
  final FeedbackModel feedback;

  const RespostaFormulario({
    Key? key,
    required this.feedback,
  }) : super(key: key);

  @override
  _RespostaFormularioState createState() => _RespostaFormularioState();
}

class _RespostaFormularioState extends State<RespostaFormulario> {
  @override
  void initState() {
    _getFeedback();
    super.initState();
  }

  _getFeedback() async {
    feedback = FeedbackService().getPorMatricula(widget.feedback.codigo!);
    setState(() {});
  }

  final _formKey = GlobalKey<FormState>();
  final _respostaFeedbackModel = RespostaFeedbackModelRequest();
  late final feedback;
  final _descricao = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        bottom: PreferredSize(
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
                      BreadCrumbItem(
                          content: Text(
                        'Responder feedback',
                        style: GoogleFonts.titilliumWeb(
                            fontSize: 22.0, fontWeight: FontWeight.bold),
                      )),
                    ],
                    divider: Icon(Icons.chevron_right),
                  )
                ],
              ),
            ),
          ),
        ),
      ),
      body: Row(
        children: [
          Expanded(
            child: Container(
              padding:
                  const EdgeInsets.symmetric(vertical: 16.0, horizontal: 16.0),
              child: Builder(
                builder: (context) => Form(
                  key: _formKey,
                  child: Padding(
                    padding: const EdgeInsets.only(top: 42.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.stretch,
                      children: [
                        Padding(
                            padding: const EdgeInsets.symmetric(vertical: 8.0),
                            child: Text(
                              '${widget.feedback.titulo}',
                              style: AppTextStyles.heading2,
                            )),
                        Padding(
                            padding: const EdgeInsets.symmetric(vertical: 8.0),
                            child: Text(
                              "${widget.feedback.descricao}",
                              style: AppTextStyles.normal,
                            )),
                        Padding(
                          padding: const EdgeInsets.symmetric(vertical: 8.0),
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.start,
                            children: [
                              Text(
                                "Nota",
                                style: GoogleFonts.titilliumWeb(fontSize: 26.0),
                              ),
                              Padding(
                                padding:
                                    const EdgeInsets.symmetric(horizontal: 8.0),
                                child: RatingBar.builder(
                                  glowColor: Colors.transparent,
                                  itemSize: 34.0,
                                  initialRating: widget.feedback.nota!,
                                  minRating: 0,
                                  maxRating: 5,
                                  direction: Axis.horizontal,
                                  allowHalfRating: true,
                                  ignoreGestures: true,
                                  itemCount: 5,
                                  itemPadding:
                                      EdgeInsets.symmetric(horizontal: 4.0),
                                  itemBuilder: (context, _) => Icon(
                                    Icons.star_rounded,
                                    color: Colors.amber,
                                  ),
                                  onRatingUpdate: (double value) {},
                                ),
                              ),
                              Text(
                                '${widget.feedback.nota!.toStringAsFixed(1)}',
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
                        Row(
                          mainAxisAlignment: MainAxisAlignment.end,
                          children: [
                            Padding(
                              padding:
                                  const EdgeInsets.symmetric(vertical: 8.0),
                              child: ButtonWidget(
                                width: 400,
                                edgeInsets:
                                    EdgeInsets.symmetric(vertical: 12.0),
                                label: 'Responder',
                                borderCircular: 8.0,
                                buttonStyle: AppButtonStyles.green,
                                onPressed: () {
                                  final form = _formKey.currentState;
                                  if (form!.validate()) {
                                    GetStorage storage = GetStorage();
                                    _respostaFeedbackModel.resposta =
                                        _descricao.text;
                                    _respostaFeedbackModel.feedbackId =
                                        widget.feedback.id;
                                    _respostaFeedbackModel.usuarioId =
                                        int.parse(storage.read("id"));
                                    print(_respostaFeedbackModel);
                                    _salvarResposta(_respostaFeedbackModel);
                                  }
                                },
                              ),
                            ),
                          ],
                        ),
                        Expanded(child: SizedBox()),
                      ],
                    ),
                  ),
                ),
              ),
            ),
          ),
          Expanded(
            child: Container(
              child: PageViewWidget(
                totalPages: 1,
                images: [Image.asset('assets/feedback.jpg')],
              ),
            ),
          ),
        ],
      ),
    );
  }

  _salvarResposta(RespostaFeedbackModelRequest request) async {
    var payload = request.toMap();
    var response = await RespostaFeedbackService().criarRespostaFeedbacks(payload);
    if(response is RespostaFeedbackModel){
      SnackBarUtils.showSnackbar(
        context,
        "Feedback respondido!" ,
        Icon(
          Icons.error,
          color: Colors.white,
        ),
        background: Colors.green,
      );
    }
    Navigator.pop(context);
  }
}
