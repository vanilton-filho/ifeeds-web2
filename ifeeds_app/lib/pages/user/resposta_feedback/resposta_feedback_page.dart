import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/pages/user/resposta_feedback/resposta_formulario.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/services/feedback_service.dart';

class RespostaFeedbackPage extends StatelessWidget {
  const RespostaFeedbackPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return StreamBuilder(
        stream: _stream(),
        builder: (context, AsyncSnapshot<dynamic> snapshot) {
          print(snapshot);
          if (snapshot.hasData) {
            List<FeedbackModel> feedbacks = snapshot.data!;
            return Container(
              child: ListView(
                children: [
                  ...feedbacks.map(
                    (e) => Padding(
                      padding: const EdgeInsets.all(12.0),
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              Text(
                                "${e.titulo}",
                                style: AppTextStyles.normal.merge(TextStyle(
                                    fontSize: 23, fontWeight: FontWeight.bold)),
                              ),
                              Text(
                                "Usuário: ${e.matricula}",
                                style: AppTextStyles.normal,
                              ),
                            ],
                          ),
                          ButtonWidget(
                              width: 250,
                              buttonStyle: e.status!
                                  ? AppButtonStyles.grey
                                  : AppButtonStyles.green,
                              onPressed: e.status!
                                  ? null
                                  : () => Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                          builder: (context) =>
                                              RespostaFormulario(feedback: e))),
                              edgeInsets: EdgeInsets.zero,
                              label: "Responder",
                              borderCircular: 15)
                        ],
                      ),
                    ),
                  ),
                ],
              ),
            );
          }

          return Center(
            child: CircularProgressIndicator(),
          );
        });
  }

  _stream() async* {
    while (true) {
      await Future.delayed(Duration(milliseconds: 5000));
      List<FeedbackModel> feedbacks = await FeedbackService().listar();
      yield feedbacks;
    }
  }
}
