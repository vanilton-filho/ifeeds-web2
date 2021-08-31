import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/resposta_feedback_model.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/services/resposta_feedback_service.dart';

class RespostaFeedbackPage extends StatelessWidget {
  const RespostaFeedbackPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: _future(),
        builder: (context, AsyncSnapshot<dynamic> snapshot) {
          print(snapshot);
          if (snapshot.hasData) {
            List<RespostaFeedbackModel> respostas = snapshot.data!;
            return Container(
              child: ListView(
                children: [
                  ...respostas.map((e) => Padding(
                        padding: const EdgeInsets.all(8.0),
                        child: Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              children: [
                                Text(
                                  "${e.titulo}",
                                  style: AppTextStyles.normal.merge(TextStyle(
                                      fontSize: 23,
                                      fontWeight: FontWeight.bold)),
                                ),
                                Text(
                                  "Usuário: ${e.usuario}",
                                  style: AppTextStyles.normal,
                                ),
                              ],
                            ),
                            ButtonWidget(
                                buttonStyle: AppButtonStyles.white,
                                onPressed: () => {},
                                edgeInsets: EdgeInsets.zero,
                                label: "Responder +",
                                borderCircular: 15)
                          ],
                        ),
                      ))
                ],
              ),
            );
          }

          return Center(
            child: CircularProgressIndicator(),
          );
        });
  }

  _future() async {
    return await RespostaFeedbackService().listaRespostasFeedbacks();
  }
}
